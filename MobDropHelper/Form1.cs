using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MobDropHelper
{
    public partial class Form1 : Form
    {
        // Dictionary to store the mappings from the file
        private Dictionary<int, string> mobNames = new Dictionary<int, string>();
        private Dictionary<int, string> itemNames = new Dictionary<int, string>();

        private string mobDropItemFilePath;
        private string mobNamesFilePath;
        private string itemNamesFilePath;

        private string mob_drop_text;
        private int dropCounter = 1;
        private bool GroupOpen = false;
        private string lastSearchType;

        public Form1()
        {
            InitializeComponent();
            // Determine the paths
            string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string mobDropPath = Path.Combine(exePath, "mob_drop");
            string namesPath = Path.Combine(exePath, "names");
            // Ensure directories exist
            Directory.CreateDirectory(mobDropPath);
            Directory.CreateDirectory(namesPath);

            // Define file paths
            mobDropItemFilePath = Path.Combine(mobDropPath, "mob_drop_item.txt");
            mobNamesFilePath = Path.Combine(namesPath, "mob_names.txt");
            itemNamesFilePath = Path.Combine(namesPath, "item_names.txt");

            listBoxResults.DoubleClick += listBoxResults_DoubleClick;
            SetPlaceholderText(textBoxItemVnum, "Enter item name here"); // Set initial placeholder text
            textBoxItemVnum.Enter += (sender, e) => ClearPlaceholderText(textBoxItemVnum, "Enter item name here");
            textBoxItemVnum.Leave += (sender, e) => SetPlaceholderText(textBoxItemVnum, "Enter item name here");
            SetPlaceholderText(textBoxMobVnum, "Enter mob name here");
            textBoxMobVnum.Enter += (sender, e) => ClearPlaceholderText(textBoxMobVnum, "Enter mob name here");
            textBoxMobVnum.Leave += (sender, e) => SetPlaceholderText(textBoxMobVnum, "Enter mob name here");
            LoadMobNames();
            LoadItemNames();
            UpdateMobAmountVisibility();
            textBoxMobVnum.TextChanged += TextBoxSearchMobVNUM_TextChanged;
            textBoxItemVnum.TextChanged += TextBoxSearchItemVNUM_TextChanged;
            textBoxMobValue.TabIndex = 0;
            textBoxItemValue.TabIndex = 1;
            textBoxQuantity.TabIndex = 2;
            textBoxPercentage.TabIndex = 3;
            if(checkBoxDrop.Checked)
            {
                buttonField.TabIndex = 4;
            }
            else if(checkBoxKill.Checked)
            {
                textBoxMobAmount.TabIndex = 4;
                textBoxKillOver.TabIndex = 5;
                buttonField.TabIndex = 6;
            }    
            else if(checkBoxLimit.Checked)
            {
                textBoxLevelLimit.TabIndex = 4;
                buttonField.TabIndex = 5;
            }  
            textBoxItemName.TabStop = false;
            textBoxMobName.TabStop = false;
            richTextBoxFile.TabStop = false;
            checkBoxDrop.TabStop = false;
            checkBoxKill.TabStop = false;
            checkBoxLimit.TabStop = false;
            buttonCreateFile.TabStop = false;
            buttonOpenFile.TabStop = false;
            buttonOpenGroup.TabStop = false;
            buttonCloseGroup.TabStop = false;
            buttonChance.TabStop = false;
            buttonWriteToFile.TabStop = false;


            textBoxItemName.TabIndex = 7;
            textBoxMobValue.TextChanged += TextBox_mobTextChanged; // If textbox change
            textBoxItemValue.TextChanged += TextBox_itemTextChanged; // If textbox change
            buttonCreateFile.Click += ButtonCreateFile_Click; // Create text file if does not exist
            buttonOpenFile.Click += buttonOpenFile_Click; // Open text file if exists
            textBoxQuantity.KeyPress += textBoxQuantity_KeyPress; // Allow just numerical values in the textbox
            checkBoxDrop.CheckedChanged += checkBoxDrop_CheckedChanged; // Change state of the checkboxes visibility
            checkBoxKill.CheckedChanged += checkBoxKill_CheckedChanged; // Change state of the checkboxes visibility
            checkBoxLimit.CheckedChanged += checkBoxLimit_CheckedChanged; // Change state of the checkboxes visibility
            buttonOpenGroup.Click += buttonOpenGroup_Click;
            buttonField.Click += buttonField_Click;
            buttonCloseGroup.Click += buttonCloseGroup_Click;
            buttonWriteToFile.Click += buttonWriteToFile_Click;
            buttonChance.Click += buttonDropChance_Click;
        }

        private void textBoxMobValue_TextChanged(object sender, EventArgs e)
        {

        }
        //READ DICTIONARY MOB NAMES   
        private void LoadMobNames()
        {
            if (File.Exists(mobNamesFilePath))
            {
                foreach (var line in File.ReadAllLines(mobNamesFilePath))
                {
                    var parts = line.Split('\t');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int number))
                    {
                        mobNames[number] = parts[1];
                    }
                }
            }
            else
            {
                MessageBox.Show("mob_names.txt not found.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //READ DICTIONARY ITEM NAMES   
        private void LoadItemNames()
        {
            if (File.Exists(itemNamesFilePath))
            {
                foreach (var line in File.ReadAllLines(itemNamesFilePath))
                {
                    var parts = line.Split('\t');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int number))
                    {
                        itemNames[number] = parts[1];
                    }
                }
            }
            else
            {
                MessageBox.Show("item_names.txt not found.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //CHECK IF TEXT CHANGE IN MOB TEXTBOX
        private void TextBox_mobTextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (int.TryParse(textBox.Text, out int inputNumber) && mobNames.ContainsKey(inputNumber))
            {
                // Set the label text to the corresponding name
                textBoxMobName.Text = mobNames[inputNumber];
            }
            else
            {
                textBoxMobName.Text = "Mob not found";
            }
        }

        //CHECK IF TEXT CHANGE IN ITEM TEXTBOX
        private void TextBox_itemTextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (int.TryParse(textBox.Text, out int inputNumber) && itemNames.ContainsKey(inputNumber))
            {
                // Set the label text to the corresponding name
                textBoxItemName.Text = itemNames[inputNumber];
            }
            else
            {
                textBoxItemName.Text = "Item not found";
            }
        }

        //CREATE TEXT FILE
        private void ButtonCreateFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(mobDropItemFilePath))
            {
                File.Create(mobDropItemFilePath).Close();
                MessageBox.Show($"File '{mobDropItemFilePath}' created successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"The file already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BUTTON THAT OPEN TEXT FILE AND ASSIGN CONTENT TO THE RICH TEXT BOX
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(mobDropItemFilePath))
            {
                string fileContent = File.ReadAllText(mobDropItemFilePath);

                //Assign the contents to the RichTextBox
                richTextBoxFile.Text = fileContent;
                // Scroll to the bottom of the RichTextBox
                richTextBoxFile.SelectionStart = richTextBoxFile.TextLength;
                richTextBoxFile.ScrollToCaret();
            }
            else
            {
                MessageBox.Show($"The file '{mobDropItemFilePath}' was not found on '{mobDropItemFilePath}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //CHECK IF TEXTBOX QUANTITY IS NUMBER
        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is not a digit and not a control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Handle event so the character is not entered in the textbox
            }
        }

        // CHECK TEXTBOX STATUSES
        private void checkBoxDrop_CheckedChanged(object sender, EventArgs e)
        {
            // This code will be executed every time the checked state of checkBoxDrop changes
            checkBoxKill.Visible = !checkBoxDrop.Checked;
            checkBoxLimit.Visible = !checkBoxDrop.Checked;
            UpdateMobAmountVisibility();

            if (checkBoxDrop.Checked)
            {
                checkBoxKill.Checked = false;
                checkBoxLimit.Checked = false;
            }
        }
        // CHECK TEXTBOX STATUSES
        private void checkBoxKill_CheckedChanged(object sender, EventArgs e)
        {
            // Logic for checkBoxKill
            // Adapt this part to your needs, for example:
            checkBoxDrop.Visible = !checkBoxKill.Checked;
            checkBoxLimit.Visible = !checkBoxKill.Checked;
            UpdateMobAmountVisibility();

            if (checkBoxKill.Checked)
            {
                checkBoxDrop.Checked = false;
                checkBoxLimit.Checked = false;
            }
        }
        // CHECK TEXTBOX STATUSES
        private void checkBoxLimit_CheckedChanged(object sender, EventArgs e)
        {
            // Logic for checkBoxLimit
            checkBoxDrop.Visible = !checkBoxLimit.Checked;
            checkBoxKill.Visible = !checkBoxLimit.Checked;
            UpdateMobAmountVisibility();

            if (checkBoxLimit.Checked)
            {
                checkBoxDrop.Checked = false;
                checkBoxKill.Checked = false;
            }
        }

        // OPEN GROUP
        private void buttonOpenGroup_Click(object sender, EventArgs e)
        {
            string mobNameText = textBoxMobName.Text.Replace(" ", "_");
            // Check if all checkboxes are unchecked
            if (!checkBoxDrop.Checked && !checkBoxKill.Checked && !checkBoxLimit.Checked)
            {
                MessageBox.Show("No option is selected. Please select an option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method
            }
            if (GroupOpen)
            {
                MessageBox.Show("Group is already open, close the current group before opening a new one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(textBoxMobValue.Text) || textBoxMobName.Text == "Mob not found")
            {
                MessageBox.Show("Mob Value field cannot be empty or mob value is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GroupOpen = true;
                if (string.IsNullOrWhiteSpace(richTextBoxFile.Text))
                {
                    richTextBoxFile.AppendText("Group\t" + mobNameText);
                    richTextBoxFile.AppendText(Environment.NewLine + "{");
                }    
                else
                {
                richTextBoxFile.AppendText(Environment.NewLine + "Group\t" + mobNameText);
                richTextBoxFile.AppendText(Environment.NewLine + "{");
                }

                if (checkBoxDrop.Checked)
                {
                    richTextBoxFile.AppendText(Environment.NewLine + "\t" + "Mob\t" + textBoxMobValue.Text);
                    richTextBoxFile.AppendText(Environment.NewLine + "\t" + "Type\tdrop");
                }
                else if (checkBoxKill.Checked)
                {
                    richTextBoxFile.AppendText(Environment.NewLine + "\t" +"Kill_drop\t" + textBoxMobAmount.Text);
                    richTextBoxFile.AppendText(Environment.NewLine + "\t" +"Mob\t" + textBoxMobValue.Text);
                    richTextBoxFile.AppendText(Environment.NewLine + "\t" +"Type\tkill");
                }
                else if (checkBoxLimit.Checked)
                {
                    richTextBoxFile.AppendText(Environment.NewLine + "\t" +"Level_limit\t" + textBoxLevelLimit.Text);
                    richTextBoxFile.AppendText(Environment.NewLine + "\t" +"Mob\t" + textBoxMobValue.Text);
                    richTextBoxFile.AppendText(Environment.NewLine + "\t" +"Type\tlimit");
                }

                // Scroll to the bottom of the RichTextBox
                richTextBoxFile.SelectionStart = richTextBoxFile.TextLength;
                richTextBoxFile.ScrollToCaret();
            }
        }
        // ADD FIELD BUTTON
        private void buttonField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxItemValue.Text) && textBoxItemName.Text == "Item not found")
            {
                MessageBox.Show("Item Value field cannot be empty or the Item selected does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if either is empty or whitespace
            }
            else
            {
                if (checkBoxDrop.Checked)
                {
                    if (string.IsNullOrWhiteSpace(textBoxQuantity.Text) || string.IsNullOrWhiteSpace(textBoxPercentage.Text) || string.IsNullOrWhiteSpace(textBoxItemValue.Text))
                    {
                        MessageBox.Show("Item value, Quantity or Percentage fields cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method if either is empty or whitespace
                    }
                    else
                    {
                        richTextBoxFile.AppendText(Environment.NewLine + "\t" + dropCounter.ToString() + "\t" + textBoxItemValue.Text + "\t" + textBoxQuantity.Text + "\t" + textBoxPercentage.Text + "\t--" + textBoxItemName.Text);
                        richTextBoxFile.SelectionStart = richTextBoxFile.TextLength;
                        richTextBoxFile.ScrollToCaret();
                        dropCounter++; // Increment the counter
                    }
                }

                else if (checkBoxKill.Checked)
                {
                    if (string.IsNullOrWhiteSpace(textBoxQuantity.Text) || string.IsNullOrWhiteSpace(textBoxPercentage.Text) || string.IsNullOrWhiteSpace(textBoxMobAmount.Text) || string.IsNullOrWhiteSpace(textBoxKillOver.Text))
                    {
                        MessageBox.Show("Quantity, Percentage, Mob Amount or Kill Over fields cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        richTextBoxFile.SelectionStart = richTextBoxFile.TextLength;
                        richTextBoxFile.ScrollToCaret();
                        return; // Exit the method if either is empty or whitespace
                    }
                    else
                    {
                        richTextBoxFile.AppendText(Environment.NewLine + "\t" + dropCounter.ToString() + "\t" + textBoxItemValue.Text + "\t" + textBoxQuantity.Text + "\t" + textBoxKillOver.Text + "\t" + textBoxPercentage.Text + "\t--" + textBoxItemName.Text);
                        richTextBoxFile.SelectionStart = richTextBoxFile.TextLength;
                        richTextBoxFile.ScrollToCaret();
                        dropCounter++; // Increment the counter
                    }
                }
                else if (checkBoxLimit.Checked)
                {
                    if (string.IsNullOrWhiteSpace(textBoxQuantity.Text) || string.IsNullOrWhiteSpace(textBoxPercentage.Text) || string.IsNullOrWhiteSpace(textBoxLevelLimit.Text))
                    {
                        MessageBox.Show("Quantity, Percentage or Level Limit fields cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method if either is empty or whitespace
                    }
                    else
                    {
                        richTextBoxFile.AppendText(Environment.NewLine + "\t" + dropCounter.ToString() + "\t" + textBoxItemValue.Text + "\t" + textBoxQuantity.Text + "\t" + textBoxPercentage.Text + "\t--" + textBoxItemName.Text);
                        dropCounter++; // Increment the counter
                    }
                }
            }
        }

        // CLOSE GROUP
        private void buttonCloseGroup_Click(object sender, EventArgs e)
        {
            if(GroupOpen == true)
            {
                richTextBoxFile.AppendText(Environment.NewLine + "}");
                richTextBoxFile.AppendText(Environment.NewLine + "");
                richTextBoxFile.SelectionStart = richTextBoxFile.TextLength;
                richTextBoxFile.ScrollToCaret();
                dropCounter = 1;
                GroupOpen = false;
            }    
            else
            {
                MessageBox.Show("Cannot close group as is not opened yet.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if either is empty or whitespace
            }    
        }

        // WRITE TO FILE
        private void buttonWriteToFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Confirmation dialog
                var result = MessageBox.Show("Are you sure you want to write to the file?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user pressed 'Yes'
                if (result == DialogResult.Yes)
                {
                    // Overwrite the file with text from the RichTextBox
                    File.WriteAllText(mobDropItemFilePath, richTextBoxFile.Text + Environment.NewLine);

                    MessageBox.Show("Content written to mob_drop_info.txt successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // If 'No' is pressed, do nothing
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // MOB AMOUNT
        private void UpdateMobAmountVisibility()
        {
            bool isVisible = checkBoxKill.Checked;
            labelMobAmount.Visible = isVisible;
            textBoxMobAmount.Visible = isVisible;
            labelKillOver.Visible = isVisible;
            textBoxKillOver.Visible = isVisible;
            buttonChance.Visible = isVisible;

            bool isLimitVisible = checkBoxLimit.Checked;
            labelLevelLimit.Visible = isLimitVisible;
            textBoxLevelLimit.Visible = isLimitVisible;
        }

        // CALCULATE DROP CHANCE
        private void buttonDropChance_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPercentage.Text))
            {
                MessageBox.Show("Percentage fields cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if either is empty or whitespace
            }
            else
            {
                double ChanceValue = Double.Parse(textBoxPercentage.Text);
                double CalcualtionMobDropChance = 0;
                CalcualtionMobDropChance = 100 / ChanceValue;
                labelChance.ForeColor = Color.Red;
                labelChance.Font = new Font(labelChance.Font, FontStyle.Bold);
                labelChance.Text = "The item has a chance of " + textBoxPercentage.Text + "% to drop.\n It will drop on average every " + CalcualtionMobDropChance.ToString() + " mobs killed.";
            }
        }

        private List<KeyValuePair<int, string>> FindMobsByName(string mobName)
        {
            var matchingMobs = new List<KeyValuePair<int, string>>();

            foreach (var pair in mobNames)
            {
                if (pair.Value.StartsWith(mobName, StringComparison.OrdinalIgnoreCase))
                {
                    matchingMobs.Add(pair);
                }
            }

            return matchingMobs;
        }
        private void TextBoxSearchMobVNUM_TextChanged(object sender, EventArgs e)
        {
            lastSearchType = "mob";
            listBoxResults.Items.Clear(); // Clear previous results
            var mobName = textBoxMobVnum.Text;

            if (!string.IsNullOrWhiteSpace(mobName))
            {
                var matchingMobs = FindMobsByName(mobName);
                if (matchingMobs.Count > 0)
                {
                    foreach (var mob in matchingMobs)
                    {
                        listBoxResults.Items.Add(mob.Key + "\t" + mob.Value);
                    }
                }
                else
                {
                    listBoxResults.Items.Add("Mob name not found.");
                }
            }
        }
        private List<KeyValuePair<int, string>> FindItemsByName(string itemName)
        {
            var matchingItems = new List<KeyValuePair<int, string>>();

            foreach (var pair in itemNames)
            {
                if (pair.Value.StartsWith(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    matchingItems.Add(pair);
                }
            }

            return matchingItems;
        }

        private void TextBoxSearchItemVNUM_TextChanged(object sender, EventArgs e)
        {
            lastSearchType = "item";
            listBoxResults.Items.Clear(); // Clear previous results
            var itemName = textBoxItemVnum.Text;

            if (!string.IsNullOrWhiteSpace(itemName))
            {
                var matchingItems = FindItemsByName(itemName);
                if (matchingItems.Count > 0)
                {
                    foreach (var item in matchingItems)
                    {
                        listBoxResults.Items.Add(item.Key + "\t" + item.Value);
                    }
                }
                else
                {
                    listBoxResults.Items.Add("Item name not found.");
                }
            }
        }

        private void SetPlaceholderText(TextBox textBox, string placeholderText)
        {
            if (textBox.Text == "")
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void ClearPlaceholderText(TextBox textBox, string placeholderText)
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void listBoxResults_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxResults.SelectedItem != null)
            {
                string selectedText = listBoxResults.SelectedItem.ToString();
                var parts = selectedText.Split('\t');
                if (parts.Length >= 2)
                {
                    string keyString = parts[0]; // Key is the first part
                    if (int.TryParse(keyString, out int key))
                    {
                        if (lastSearchType == "mob")
                        {
                            textBoxMobValue.Text = key.ToString();
                        }
                        else if (lastSearchType == "item")
                        {
                            textBoxItemValue.Text = key.ToString();
                        }
                    }
                }
            }
        }

    }
}
