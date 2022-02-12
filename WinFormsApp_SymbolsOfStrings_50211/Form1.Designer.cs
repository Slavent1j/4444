
namespace WinFormsApp_SymbolsOfStrings_50211
{
    partial class form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.textbox_Letter = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_FindLetter = new System.Windows.Forms.Button();
            this.label_AboutInput = new System.Windows.Forms.Label();
            this.label_AboutLetter = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ToolStripMenu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Input
            // 
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.ItemHeight = 15;
            this.listBox_Input.Location = new System.Drawing.Point(38, 100);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(291, 199);
            this.listBox_Input.TabIndex = 0;
            // 
            // textbox_Letter
            // 
            this.textbox_Letter.Location = new System.Drawing.Point(504, 247);
            this.textbox_Letter.MaxLength = 1;
            this.textbox_Letter.Name = "textbox_Letter";
            this.textbox_Letter.Size = new System.Drawing.Size(111, 23);
            this.textbox_Letter.TabIndex = 1;
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(38, 305);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 23);
            this.button_Open.TabIndex = 2;
            this.button_Open.Text = "Открыть";
            this.button_Open.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(254, 305);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "Очистить!";
            this.button_Clear.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(38, 386);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            // 
            // button_FindLetter
            // 
            this.button_FindLetter.Location = new System.Drawing.Point(504, 276);
            this.button_FindLetter.Name = "button_FindLetter";
            this.button_FindLetter.Size = new System.Drawing.Size(75, 23);
            this.button_FindLetter.TabIndex = 5;
            this.button_FindLetter.Text = "Посчитать";
            this.button_FindLetter.UseVisualStyleBackColor = true;
            // 
            // label_AboutInput
            // 
            this.label_AboutInput.AutoSize = true;
            this.label_AboutInput.Location = new System.Drawing.Point(38, 82);
            this.label_AboutInput.Name = "label_AboutInput";
            this.label_AboutInput.Size = new System.Drawing.Size(141, 15);
            this.label_AboutInput.TabIndex = 6;
            this.label_AboutInput.Text = "Набор строк для поиска";
            // 
            // label_AboutLetter
            // 
            this.label_AboutLetter.AutoSize = true;
            this.label_AboutLetter.Location = new System.Drawing.Point(504, 229);
            this.label_AboutLetter.Name = "label_AboutLetter";
            this.label_AboutLetter.Size = new System.Drawing.Size(80, 15);
            this.label_AboutLetter.TabIndex = 7;
            this.label_AboutLetter.Text = "Буква поиска";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_File,
            this.ToolStripMenu_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "Файл";
            // 
            // ToolStripMenu_File
            // 
            this.ToolStripMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_Open,
            this.ToolStripMenu_Clear,
            this.ToolStripMenu_Exit});
            this.ToolStripMenu_File.Name = "ToolStripMenu_File";
            this.ToolStripMenu_File.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenu_File.Text = "Файл";
            // 
            // ToolStripMenu_Help
            // 
            this.ToolStripMenu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_About});
            this.ToolStripMenu_Help.Name = "ToolStripMenu_Help";
            this.ToolStripMenu_Help.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenu_Help.Text = "Помощь";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(196, 17);
            this.toolStripStatusLabel1.Text = "Приложение загружено успешно!";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "*.txt|*.txt";
            // 
            // ToolStripMenu_Open
            // 
            this.ToolStripMenu_Open.Name = "ToolStripMenu_Open";
            this.ToolStripMenu_Open.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenu_Open.Text = "Открыть";
            // 
            // ToolStripMenu_Clear
            // 
            this.ToolStripMenu_Clear.Name = "ToolStripMenu_Clear";
            this.ToolStripMenu_Clear.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenu_Clear.Text = "Очистить";
            // 
            // ToolStripMenu_Exit
            // 
            this.ToolStripMenu_Exit.Name = "ToolStripMenu_Exit";
            this.ToolStripMenu_Exit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenu_Exit.Text = "Выход";
            // 
            // ToolStripMenu_About
            // 
            this.ToolStripMenu_About.Name = "ToolStripMenu_About";
            this.ToolStripMenu_About.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenu_About.Text = "О программе";
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label_AboutLetter);
            this.Controls.Add(this.label_AboutInput);
            this.Controls.Add(this.button_FindLetter);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textbox_Letter);
            this.Controls.Add(this.listBox_Input);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "form_Main";
            this.Text = "Работа со строками";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.TextBox textbox_Letter;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_FindLetter;
        private System.Windows.Forms.Label label_AboutInput;
        private System.Windows.Forms.Label label_AboutLetter;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Help;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Clear;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_About;
    }
}

