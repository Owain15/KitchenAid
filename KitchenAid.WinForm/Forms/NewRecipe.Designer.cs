namespace KitchenAid.WinForm.Forms
{
    partial class NewRecipe
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
            inputTableLayout = new TableLayoutPanel();
            outputTableLayout = new TableLayoutPanel();
            buttonsTableLayout = new TableLayoutPanel();
            tableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 2;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout.Controls.Add(inputTableLayout, 1, 1);
            tableLayout.Controls.Add(outputTableLayout, 1, 3);
            tableLayout.Controls.Add(buttonsTableLayout, 1, 5);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 8;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout.Size = new Size(264, 144);
            tableLayout.TabIndex = 0;
            // 
            // inputTableLayout
            // 
            inputTableLayout.ColumnCount = 2;
            inputTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            inputTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            inputTableLayout.Dock = DockStyle.Fill;
            inputTableLayout.Location = new Point(23, 23);
            inputTableLayout.Name = "inputTableLayout";
            inputTableLayout.RowCount = 1;
            inputTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            inputTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            inputTableLayout.Size = new Size(238, 24);
            inputTableLayout.TabIndex = 0;
            // 
            // outputTableLayout
            // 
            outputTableLayout.ColumnCount = 2;
            outputTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            outputTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            outputTableLayout.Dock = DockStyle.Fill;
            outputTableLayout.Location = new Point(23, 63);
            outputTableLayout.Name = "outputTableLayout";
            outputTableLayout.RowCount = 1;
            outputTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            outputTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            outputTableLayout.Size = new Size(238, 14);
            outputTableLayout.TabIndex = 1;
            // 
            // buttonsTableLayout
            // 
            buttonsTableLayout.ColumnCount = 2;
            buttonsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            buttonsTableLayout.Dock = DockStyle.Fill;
            buttonsTableLayout.Location = new Point(23, 93);
            buttonsTableLayout.Name = "buttonsTableLayout";
            buttonsTableLayout.RowCount = 1;
            buttonsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buttonsTableLayout.Size = new Size(238, 29);
            buttonsTableLayout.TabIndex = 2;
            // 
            // NewRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 144);
            Controls.Add(tableLayout);
            Name = "NewRecipe";
            Text = "KitchenAid-NewRecipe";
            tableLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayout;
        private TableLayoutPanel inputTableLayout;
        private TableLayoutPanel outputTableLayout;
        private TableLayoutPanel buttonsTableLayout;
    }
}