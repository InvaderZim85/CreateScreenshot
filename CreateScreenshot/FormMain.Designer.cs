namespace CreateScreenshot
{
    partial class FormMain
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
            textBoxTarget = new TextBox();
            buttonBrowse = new Button();
            labelTarget = new Label();
            groupBoxSettings = new GroupBox();
            buttonClear = new Button();
            labelType = new Label();
            radioButtonGray = new RadioButton();
            radioButtonColor = new RadioButton();
            groupBoxPicture = new GroupBox();
            pictureBox = new PictureBox();
            panelPictureTop = new Panel();
            buttonScreenshot = new Button();
            groupBoxSettings.SuspendLayout();
            groupBoxPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelPictureTop.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTarget
            // 
            textBoxTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTarget.Location = new Point(55, 23);
            textBoxTarget.Name = "textBoxTarget";
            textBoxTarget.Size = new Size(673, 23);
            textBoxTarget.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBrowse.Location = new Point(734, 23);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(50, 23);
            buttonBrowse.TabIndex = 1;
            buttonBrowse.Text = "...";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += ButtonBrowse_Click;
            // 
            // labelTarget
            // 
            labelTarget.AutoSize = true;
            labelTarget.Location = new Point(6, 26);
            labelTarget.Name = "labelTarget";
            labelTarget.Size = new Size(43, 15);
            labelTarget.TabIndex = 2;
            labelTarget.Text = "Target:";
            // 
            // groupBoxSettings
            // 
            groupBoxSettings.Controls.Add(buttonClear);
            groupBoxSettings.Controls.Add(labelType);
            groupBoxSettings.Controls.Add(radioButtonGray);
            groupBoxSettings.Controls.Add(radioButtonColor);
            groupBoxSettings.Controls.Add(buttonBrowse);
            groupBoxSettings.Controls.Add(labelTarget);
            groupBoxSettings.Controls.Add(textBoxTarget);
            groupBoxSettings.Dock = DockStyle.Top;
            groupBoxSettings.Location = new Point(5, 5);
            groupBoxSettings.Name = "groupBoxSettings";
            groupBoxSettings.Size = new Size(790, 81);
            groupBoxSettings.TabIndex = 3;
            groupBoxSettings.TabStop = false;
            groupBoxSettings.Text = "Settings";
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClear.Location = new Point(734, 52);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(50, 23);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(14, 55);
            labelType.Name = "labelType";
            labelType.Size = new Size(35, 15);
            labelType.TabIndex = 6;
            labelType.Text = "Type:";
            // 
            // radioButtonGray
            // 
            radioButtonGray.AutoSize = true;
            radioButtonGray.Location = new Point(115, 53);
            radioButtonGray.Name = "radioButtonGray";
            radioButtonGray.Size = new Size(49, 19);
            radioButtonGray.TabIndex = 5;
            radioButtonGray.Text = "Gray";
            radioButtonGray.UseVisualStyleBackColor = true;
            // 
            // radioButtonColor
            // 
            radioButtonColor.AutoSize = true;
            radioButtonColor.Checked = true;
            radioButtonColor.Location = new Point(55, 53);
            radioButtonColor.Name = "radioButtonColor";
            radioButtonColor.Size = new Size(54, 19);
            radioButtonColor.TabIndex = 4;
            radioButtonColor.TabStop = true;
            radioButtonColor.Text = "Color";
            radioButtonColor.UseVisualStyleBackColor = true;
            // 
            // groupBoxPicture
            // 
            groupBoxPicture.Controls.Add(pictureBox);
            groupBoxPicture.Controls.Add(panelPictureTop);
            groupBoxPicture.Dock = DockStyle.Fill;
            groupBoxPicture.Location = new Point(5, 86);
            groupBoxPicture.Name = "groupBoxPicture";
            groupBoxPicture.Size = new Size(790, 359);
            groupBoxPicture.TabIndex = 4;
            groupBoxPicture.TabStop = false;
            groupBoxPicture.Text = "Screenshot";
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = CreateScreenshot.Properties.Resources.DummyImage;
            pictureBox.Location = new Point(3, 50);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(784, 306);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // panelPictureTop
            // 
            panelPictureTop.Controls.Add(buttonScreenshot);
            panelPictureTop.Dock = DockStyle.Top;
            panelPictureTop.Location = new Point(3, 19);
            panelPictureTop.Name = "panelPictureTop";
            panelPictureTop.Size = new Size(784, 31);
            panelPictureTop.TabIndex = 1;
            // 
            // buttonScreenshot
            // 
            buttonScreenshot.Location = new Point(3, 3);
            buttonScreenshot.Name = "buttonScreenshot";
            buttonScreenshot.Size = new Size(125, 23);
            buttonScreenshot.TabIndex = 0;
            buttonScreenshot.Text = "Take Screenshot";
            buttonScreenshot.UseVisualStyleBackColor = true;
            buttonScreenshot.Click += buttonScreenshot_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxPicture);
            Controls.Add(groupBoxSettings);
            Name = "FormMain";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screenshot";
            groupBoxSettings.ResumeLayout(false);
            groupBoxSettings.PerformLayout();
            groupBoxPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelPictureTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxTarget;
        private Button buttonBrowse;
        private Label labelTarget;
        private GroupBox groupBoxSettings;
        private Label labelType;
        private RadioButton radioButtonGray;
        private RadioButton radioButtonColor;
        private Button buttonClear;
        private GroupBox groupBoxPicture;
        private PictureBox pictureBox;
        private Panel panelPictureTop;
        private Button buttonScreenshot;
    }
}
