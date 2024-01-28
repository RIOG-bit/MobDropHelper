namespace MobDropHelper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxMobValue = new System.Windows.Forms.TextBox();
            this.labelMobValue = new System.Windows.Forms.Label();
            this.labelMobName = new System.Windows.Forms.Label();
            this.labelMobNames = new System.Windows.Forms.Label();
            this.textBoxMobName = new System.Windows.Forms.TextBox();
            this.labelItemValue = new System.Windows.Forms.Label();
            this.textBoxItemValue = new System.Windows.Forms.TextBox();
            this.labelItemNames = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.richTextBoxFile = new System.Windows.Forms.RichTextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.textBoxPercentage = new System.Windows.Forms.TextBox();
            this.checkBoxDrop = new System.Windows.Forms.CheckBox();
            this.checkBoxKill = new System.Windows.Forms.CheckBox();
            this.checkBoxLimit = new System.Windows.Forms.CheckBox();
            this.buttonField = new System.Windows.Forms.Button();
            this.buttonOpenGroup = new System.Windows.Forms.Button();
            this.buttonCloseGroup = new System.Windows.Forms.Button();
            this.buttonWriteToFile = new System.Windows.Forms.Button();
            this.labelMobAmount = new System.Windows.Forms.Label();
            this.textBoxMobAmount = new System.Windows.Forms.TextBox();
            this.labelKillOver = new System.Windows.Forms.Label();
            this.textBoxKillOver = new System.Windows.Forms.TextBox();
            this.labelLevelLimit = new System.Windows.Forms.Label();
            this.textBoxLevelLimit = new System.Windows.Forms.TextBox();
            this.labelChance = new System.Windows.Forms.Label();
            this.buttonChance = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxItemVnum = new System.Windows.Forms.TextBox();
            this.textBoxMobVnum = new System.Windows.Forms.TextBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMobValue
            // 
            this.textBoxMobValue.Location = new System.Drawing.Point(300, 148);
            this.textBoxMobValue.Name = "textBoxMobValue";
            this.textBoxMobValue.ReadOnly = true;
            this.textBoxMobValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxMobValue.TabIndex = 0;
            this.textBoxMobValue.TextChanged += new System.EventHandler(this.textBoxMobValue_TextChanged);
            // 
            // labelMobValue
            // 
            this.labelMobValue.AutoSize = true;
            this.labelMobValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobValue.Location = new System.Drawing.Point(235, 151);
            this.labelMobValue.Name = "labelMobValue";
            this.labelMobValue.Size = new System.Drawing.Size(67, 13);
            this.labelMobValue.TabIndex = 1;
            this.labelMobValue.Text = "Mob Value";
            // 
            // labelMobName
            // 
            this.labelMobName.AutoSize = true;
            this.labelMobName.Location = new System.Drawing.Point(434, 151);
            this.labelMobName.Name = "labelMobName";
            this.labelMobName.Size = new System.Drawing.Size(0, 13);
            this.labelMobName.TabIndex = 2;
            // 
            // labelMobNames
            // 
            this.labelMobNames.AutoSize = true;
            this.labelMobNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobNames.Location = new System.Drawing.Point(406, 151);
            this.labelMobNames.Name = "labelMobNames";
            this.labelMobNames.Size = new System.Drawing.Size(67, 13);
            this.labelMobNames.TabIndex = 3;
            this.labelMobNames.Text = "Mob Name";
            // 
            // textBoxMobName
            // 
            this.textBoxMobName.Location = new System.Drawing.Point(475, 148);
            this.textBoxMobName.Name = "textBoxMobName";
            this.textBoxMobName.ReadOnly = true;
            this.textBoxMobName.Size = new System.Drawing.Size(386, 20);
            this.textBoxMobName.TabIndex = 4;
            // 
            // labelItemValue
            // 
            this.labelItemValue.AutoSize = true;
            this.labelItemValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemValue.Location = new System.Drawing.Point(235, 181);
            this.labelItemValue.Name = "labelItemValue";
            this.labelItemValue.Size = new System.Drawing.Size(67, 13);
            this.labelItemValue.TabIndex = 5;
            this.labelItemValue.Text = "Item Value";
            // 
            // textBoxItemValue
            // 
            this.textBoxItemValue.Location = new System.Drawing.Point(300, 178);
            this.textBoxItemValue.Name = "textBoxItemValue";
            this.textBoxItemValue.ReadOnly = true;
            this.textBoxItemValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxItemValue.TabIndex = 6;
            // 
            // labelItemNames
            // 
            this.labelItemNames.AutoSize = true;
            this.labelItemNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemNames.Location = new System.Drawing.Point(406, 181);
            this.labelItemNames.Name = "labelItemNames";
            this.labelItemNames.Size = new System.Drawing.Size(67, 13);
            this.labelItemNames.TabIndex = 7;
            this.labelItemNames.Text = "Item Name";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(475, 178);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.ReadOnly = true;
            this.textBoxItemName.Size = new System.Drawing.Size(386, 20);
            this.textBoxItemName.TabIndex = 8;
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Location = new System.Drawing.Point(238, 699);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateFile.TabIndex = 9;
            this.buttonCreateFile.Text = "Create txt ";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            // 
            // richTextBoxFile
            // 
            this.richTextBoxFile.Location = new System.Drawing.Point(238, 234);
            this.richTextBoxFile.Name = "richTextBoxFile";
            this.richTextBoxFile.ReadOnly = true;
            this.richTextBoxFile.Size = new System.Drawing.Size(991, 459);
            this.richTextBoxFile.TabIndex = 10;
            this.richTextBoxFile.Text = "";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(319, 699);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 11;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(870, 151);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(82, 13);
            this.labelQuantity.TabIndex = 12;
            this.labelQuantity.Text = "Item Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(955, 148);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 13;
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentage.Location = new System.Drawing.Point(1060, 151);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(93, 13);
            this.labelPercentage.TabIndex = 14;
            this.labelPercentage.Text = "Percentage [%]";
            // 
            // textBoxPercentage
            // 
            this.textBoxPercentage.Location = new System.Drawing.Point(1150, 148);
            this.textBoxPercentage.Name = "textBoxPercentage";
            this.textBoxPercentage.Size = new System.Drawing.Size(79, 20);
            this.textBoxPercentage.TabIndex = 15;
            // 
            // checkBoxDrop
            // 
            this.checkBoxDrop.AutoSize = true;
            this.checkBoxDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDrop.Location = new System.Drawing.Point(300, 210);
            this.checkBoxDrop.Name = "checkBoxDrop";
            this.checkBoxDrop.Size = new System.Drawing.Size(53, 17);
            this.checkBoxDrop.TabIndex = 18;
            this.checkBoxDrop.Text = "Drop";
            this.checkBoxDrop.UseVisualStyleBackColor = true;
            // 
            // checkBoxKill
            // 
            this.checkBoxKill.AutoSize = true;
            this.checkBoxKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKill.Location = new System.Drawing.Point(400, 210);
            this.checkBoxKill.Name = "checkBoxKill";
            this.checkBoxKill.Size = new System.Drawing.Size(43, 17);
            this.checkBoxKill.TabIndex = 19;
            this.checkBoxKill.Text = "Kill";
            this.checkBoxKill.UseVisualStyleBackColor = true;
            // 
            // checkBoxLimit
            // 
            this.checkBoxLimit.AutoSize = true;
            this.checkBoxLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLimit.Location = new System.Drawing.Point(500, 210);
            this.checkBoxLimit.Name = "checkBoxLimit";
            this.checkBoxLimit.Size = new System.Drawing.Size(52, 17);
            this.checkBoxLimit.TabIndex = 20;
            this.checkBoxLimit.Text = "Limit";
            this.checkBoxLimit.UseVisualStyleBackColor = true;
            // 
            // buttonField
            // 
            this.buttonField.Location = new System.Drawing.Point(481, 699);
            this.buttonField.Name = "buttonField";
            this.buttonField.Size = new System.Drawing.Size(75, 23);
            this.buttonField.TabIndex = 21;
            this.buttonField.Text = "Add Field";
            this.buttonField.UseVisualStyleBackColor = true;
            // 
            // buttonOpenGroup
            // 
            this.buttonOpenGroup.Location = new System.Drawing.Point(400, 699);
            this.buttonOpenGroup.Name = "buttonOpenGroup";
            this.buttonOpenGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenGroup.TabIndex = 22;
            this.buttonOpenGroup.Text = "Open Group";
            this.buttonOpenGroup.UseVisualStyleBackColor = true;
            // 
            // buttonCloseGroup
            // 
            this.buttonCloseGroup.Location = new System.Drawing.Point(562, 699);
            this.buttonCloseGroup.Name = "buttonCloseGroup";
            this.buttonCloseGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseGroup.TabIndex = 23;
            this.buttonCloseGroup.Text = "Close Group";
            this.buttonCloseGroup.UseVisualStyleBackColor = true;
            // 
            // buttonWriteToFile
            // 
            this.buttonWriteToFile.Location = new System.Drawing.Point(643, 699);
            this.buttonWriteToFile.Name = "buttonWriteToFile";
            this.buttonWriteToFile.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteToFile.TabIndex = 24;
            this.buttonWriteToFile.Text = "Write To File";
            this.buttonWriteToFile.UseVisualStyleBackColor = true;
            // 
            // labelMobAmount
            // 
            this.labelMobAmount.AutoSize = true;
            this.labelMobAmount.Location = new System.Drawing.Point(870, 181);
            this.labelMobAmount.Name = "labelMobAmount";
            this.labelMobAmount.Size = new System.Drawing.Size(67, 13);
            this.labelMobAmount.TabIndex = 25;
            this.labelMobAmount.Text = "Mob Amount";
            this.labelMobAmount.Visible = false;
            // 
            // textBoxMobAmount
            // 
            this.textBoxMobAmount.Location = new System.Drawing.Point(945, 178);
            this.textBoxMobAmount.Name = "textBoxMobAmount";
            this.textBoxMobAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxMobAmount.TabIndex = 26;
            this.textBoxMobAmount.Visible = false;
            // 
            // labelKillOver
            // 
            this.labelKillOver.AutoSize = true;
            this.labelKillOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKillOver.Location = new System.Drawing.Point(1063, 181);
            this.labelKillOver.Name = "labelKillOver";
            this.labelKillOver.Size = new System.Drawing.Size(55, 13);
            this.labelKillOver.TabIndex = 27;
            this.labelKillOver.Text = "Kill Over";
            this.labelKillOver.Visible = false;
            // 
            // textBoxKillOver
            // 
            this.textBoxKillOver.Location = new System.Drawing.Point(1120, 178);
            this.textBoxKillOver.Name = "textBoxKillOver";
            this.textBoxKillOver.Size = new System.Drawing.Size(109, 20);
            this.textBoxKillOver.TabIndex = 28;
            this.textBoxKillOver.Visible = false;
            // 
            // labelLevelLimit
            // 
            this.labelLevelLimit.AutoSize = true;
            this.labelLevelLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevelLimit.Location = new System.Drawing.Point(873, 181);
            this.labelLevelLimit.Name = "labelLevelLimit";
            this.labelLevelLimit.Size = new System.Drawing.Size(68, 13);
            this.labelLevelLimit.TabIndex = 29;
            this.labelLevelLimit.Text = "Level Limit";
            this.labelLevelLimit.Visible = false;
            // 
            // textBoxLevelLimit
            // 
            this.textBoxLevelLimit.Location = new System.Drawing.Point(955, 178);
            this.textBoxLevelLimit.Name = "textBoxLevelLimit";
            this.textBoxLevelLimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxLevelLimit.TabIndex = 30;
            this.textBoxLevelLimit.Visible = false;
            // 
            // labelChance
            // 
            this.labelChance.AutoSize = true;
            this.labelChance.Location = new System.Drawing.Point(873, 211);
            this.labelChance.Name = "labelChance";
            this.labelChance.Size = new System.Drawing.Size(0, 13);
            this.labelChance.TabIndex = 31;
            // 
            // buttonChance
            // 
            this.buttonChance.Location = new System.Drawing.Point(724, 699);
            this.buttonChance.Name = "buttonChance";
            this.buttonChance.Size = new System.Drawing.Size(137, 23);
            this.buttonChance.TabIndex = 32;
            this.buttonChance.Text = "Calculate drop chance";
            this.buttonChance.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.ImageLocation = "Resources/wall.jpg";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1219, 125);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxItemVnum
            // 
            this.textBoxItemVnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemVnum.Location = new System.Drawing.Point(12, 178);
            this.textBoxItemVnum.Name = "textBoxItemVnum";
            this.textBoxItemVnum.Size = new System.Drawing.Size(217, 20);
            this.textBoxItemVnum.TabIndex = 35;
            // 
            // textBoxMobVnum
            // 
            this.textBoxMobVnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMobVnum.Location = new System.Drawing.Point(12, 148);
            this.textBoxMobVnum.Name = "textBoxMobVnum";
            this.textBoxMobVnum.Size = new System.Drawing.Size(217, 20);
            this.textBoxMobVnum.TabIndex = 38;
            // 
            // listBoxResults
            // 
            this.listBoxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(12, 208);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(220, 511);
            this.listBoxResults.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Types:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.textBoxMobVnum);
            this.Controls.Add(this.textBoxItemVnum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonChance);
            this.Controls.Add(this.labelChance);
            this.Controls.Add(this.textBoxLevelLimit);
            this.Controls.Add(this.labelLevelLimit);
            this.Controls.Add(this.textBoxKillOver);
            this.Controls.Add(this.labelKillOver);
            this.Controls.Add(this.textBoxMobAmount);
            this.Controls.Add(this.labelMobAmount);
            this.Controls.Add(this.buttonWriteToFile);
            this.Controls.Add(this.buttonCloseGroup);
            this.Controls.Add(this.buttonOpenGroup);
            this.Controls.Add(this.buttonField);
            this.Controls.Add(this.checkBoxLimit);
            this.Controls.Add(this.checkBoxKill);
            this.Controls.Add(this.checkBoxDrop);
            this.Controls.Add(this.textBoxPercentage);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.richTextBoxFile);
            this.Controls.Add(this.buttonCreateFile);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.labelItemNames);
            this.Controls.Add(this.textBoxItemValue);
            this.Controls.Add(this.labelItemValue);
            this.Controls.Add(this.textBoxMobName);
            this.Controls.Add(this.labelMobNames);
            this.Controls.Add(this.labelMobName);
            this.Controls.Add(this.labelMobValue);
            this.Controls.Add(this.textBoxMobValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MobDropHelper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMobValue;
        private System.Windows.Forms.Label labelMobValue;
        private System.Windows.Forms.Label labelMobName;
        private System.Windows.Forms.Label labelMobNames;
        private System.Windows.Forms.TextBox textBoxMobName;
        private System.Windows.Forms.Label labelItemValue;
        private System.Windows.Forms.TextBox textBoxItemValue;
        private System.Windows.Forms.Label labelItemNames;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.RichTextBox richTextBoxFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.TextBox textBoxPercentage;
        private System.Windows.Forms.CheckBox checkBoxDrop;
        private System.Windows.Forms.CheckBox checkBoxKill;
        private System.Windows.Forms.CheckBox checkBoxLimit;
        private System.Windows.Forms.Button buttonField;
        private System.Windows.Forms.Button buttonOpenGroup;
        private System.Windows.Forms.Button buttonCloseGroup;
        private System.Windows.Forms.Button buttonWriteToFile;
        private System.Windows.Forms.Label labelMobAmount;
        private System.Windows.Forms.TextBox textBoxMobAmount;
        private System.Windows.Forms.Label labelKillOver;
        private System.Windows.Forms.TextBox textBoxKillOver;
        private System.Windows.Forms.Label labelLevelLimit;
        private System.Windows.Forms.TextBox textBoxLevelLimit;
        private System.Windows.Forms.Label labelChance;
        private System.Windows.Forms.Button buttonChance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxItemVnum;
        private System.Windows.Forms.TextBox textBoxMobVnum;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label label1;
    }
}

