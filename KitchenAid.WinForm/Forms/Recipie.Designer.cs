namespace KitchenAid.WinForm.Forms
{
    partial class Recipie
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
            tableLayout = new TableLayoutPanel();
            nameIdPanel = new Panel();
            nameIdTableLayout = new TableLayoutPanel();
            nameLable = new Label();
            IdLabel = new Label();
            nameDataComboBox = new ComboBox();
            IdDataLabel = new Label();
            tableLayout.SuspendLayout();
            nameIdPanel.SuspendLayout();
            nameIdTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 3;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.Controls.Add(nameIdPanel, 1, 1);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 5;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 54.5454559F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 45.4545441F));
            tableLayout.Size = new Size(800, 450);
            tableLayout.TabIndex = 0;
            // 
            // nameIdPanel
            // 
            tableLayout.SetColumnSpan(nameIdPanel, 2);
            nameIdPanel.Controls.Add(nameIdTableLayout);
            nameIdPanel.Dock = DockStyle.Fill;
            nameIdPanel.Location = new Point(23, 23);
            nameIdPanel.Name = "nameIdPanel";
            nameIdPanel.Size = new Size(774, 29);
            nameIdPanel.TabIndex = 0;
            // 
            // nameIdTableLayout
            // 
            nameIdTableLayout.ColumnCount = 6;
            nameIdTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            nameIdTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            nameIdTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            nameIdTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            nameIdTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            nameIdTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            nameIdTableLayout.Controls.Add(nameLable, 0, 0);
            nameIdTableLayout.Controls.Add(IdLabel, 4, 0);
            nameIdTableLayout.Controls.Add(nameDataComboBox, 2, 0);
            nameIdTableLayout.Controls.Add(IdDataLabel, 5, 0);
            nameIdTableLayout.Dock = DockStyle.Fill;
            nameIdTableLayout.Location = new Point(0, 0);
            nameIdTableLayout.Name = "nameIdTableLayout";
            nameIdTableLayout.RowCount = 1;
            nameIdTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            nameIdTableLayout.Size = new Size(774, 29);
            nameIdTableLayout.TabIndex = 0;
            // 
            // nameLable
            // 
            nameLable.AutoSize = true;
            nameLable.Dock = DockStyle.Fill;
            nameLable.Location = new Point(3, 0);
            nameLable.Name = "nameLable";
            nameLable.Size = new Size(74, 29);
            nameLable.TabIndex = 0;
            nameLable.Text = "Name :";
            nameLable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Dock = DockStyle.Fill;
            IdLabel.Location = new Point(258, 0);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(44, 29);
            IdLabel.TabIndex = 1;
            IdLabel.Text = " ID :";
            IdLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameDataComboBox
            // 
            nameDataComboBox.FormattingEnabled = true;
            nameDataComboBox.Location = new Point(88, 3);
            nameDataComboBox.Name = "nameDataComboBox";
            nameDataComboBox.Size = new Size(121, 23);
            nameDataComboBox.TabIndex = 2;
            nameDataComboBox.SelectedIndexChanged += nameDataComboBox_SelectedIndexChanged;
            // 
            // IdDataLabel
            // 
            IdDataLabel.AutoSize = true;
            IdDataLabel.Dock = DockStyle.Fill;
            IdDataLabel.Location = new Point(308, 0);
            IdDataLabel.Name = "IdDataLabel";
            IdDataLabel.Size = new Size(463, 29);
            IdDataLabel.TabIndex = 3;
            IdDataLabel.Text = "- - - - - -";
            IdDataLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Recipie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayout);
            Name = "Recipie";
            Text = "KiitchenAid-Recipie";
            tableLayout.ResumeLayout(false);
            nameIdPanel.ResumeLayout(false);
            nameIdTableLayout.ResumeLayout(false);
            nameIdTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayout;
        private Panel nameIdPanel;
        private TableLayoutPanel nameIdTableLayout;
        private Label nameLable;
        private Label IdLabel;
        private ComboBox nameDataComboBox;
        private Label IdDataLabel;
    }
}