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
            tableLayoutPanel2 = new TableLayoutPanel();
            editLabel = new Label();
            newRecipeButton = new Button();
            IngredeantsTableLayout = new TableLayoutPanel();
            IngredeantsLabel = new Label();
            ingredeantsDataGridView = new DataGridView();
            ingredeantColumn = new DataGridViewTextBoxColumn();
            mesurmentColumn = new DataGridViewTextBoxColumn();
            unitColumn = new DataGridViewTextBoxColumn();
            instructionsTableLayout = new TableLayoutPanel();
            instructionLabel = new Label();
            instructiconTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            finalMesureLabel = new Label();
            finalMesureDataLabel = new Label();
            finalMesureDataUnitLabel = new Label();
            updateButton = new Button();
            deleteButton = new Button();
            tableLayout.SuspendLayout();
            nameIdPanel.SuspendLayout();
            nameIdTableLayout.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            IngredeantsTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ingredeantsDataGridView).BeginInit();
            instructionsTableLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 3;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.Controls.Add(nameIdPanel, 1, 1);
            tableLayout.Controls.Add(IngredeantsTableLayout, 1, 5);
            tableLayout.Controls.Add(instructionsTableLayout, 1, 7);
            tableLayout.Controls.Add(tableLayoutPanel1, 1, 3);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 11;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
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
            nameIdPanel.Size = new Size(774, 64);
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
            nameIdTableLayout.Controls.Add(tableLayoutPanel2, 0, 2);
            nameIdTableLayout.Dock = DockStyle.Fill;
            nameIdTableLayout.Location = new Point(0, 0);
            nameIdTableLayout.Name = "nameIdTableLayout";
            nameIdTableLayout.RowCount = 3;
            nameIdTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            nameIdTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            nameIdTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            nameIdTableLayout.Size = new Size(774, 64);
            nameIdTableLayout.TabIndex = 0;
            // 
            // nameLable
            // 
            nameLable.AutoSize = true;
            nameLable.Dock = DockStyle.Fill;
            nameLable.Location = new Point(3, 0);
            nameLable.Name = "nameLable";
            nameLable.Size = new Size(74, 30);
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
            IdLabel.Size = new Size(44, 30);
            IdLabel.TabIndex = 1;
            IdLabel.Text = " ID :";
            IdLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameDataComboBox
            // 
            nameDataComboBox.Dock = DockStyle.Fill;
            nameDataComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nameDataComboBox.FormattingEnabled = true;
            nameDataComboBox.Location = new Point(88, 3);
            nameDataComboBox.Name = "nameDataComboBox";
            nameDataComboBox.Size = new Size(144, 23);
            nameDataComboBox.TabIndex = 2;
            nameDataComboBox.SelectedIndexChanged += nameDataComboBox_SelectedIndexChanged;
            // 
            // IdDataLabel
            // 
            IdDataLabel.AutoSize = true;
            IdDataLabel.Dock = DockStyle.Fill;
            IdDataLabel.Location = new Point(308, 0);
            IdDataLabel.Name = "IdDataLabel";
            IdDataLabel.Size = new Size(463, 30);
            IdDataLabel.TabIndex = 3;
            IdDataLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 10;
            nameIdTableLayout.SetColumnSpan(tableLayoutPanel2, 6);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(editLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(newRecipeButton, 3, 0);
            tableLayoutPanel2.Controls.Add(updateButton, 5, 0);
            tableLayoutPanel2.Controls.Add(deleteButton, 7, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 38);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(768, 29);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // editLabel
            // 
            editLabel.AutoSize = true;
            editLabel.Dock = DockStyle.Fill;
            editLabel.Location = new Point(3, 0);
            editLabel.Name = "editLabel";
            editLabel.Size = new Size(44, 29);
            editLabel.TabIndex = 0;
            editLabel.Text = "Edit :";
            editLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // newRecipeButton
            // 
            newRecipeButton.Dock = DockStyle.Fill;
            newRecipeButton.Location = new Point(93, 3);
            newRecipeButton.Name = "newRecipeButton";
            newRecipeButton.Size = new Size(74, 23);
            newRecipeButton.TabIndex = 1;
            newRecipeButton.Text = "New";
            newRecipeButton.UseVisualStyleBackColor = true;
            newRecipeButton.Click += newRecipeButton_Click;
            // 
            // IngredeantsTableLayout
            // 
            IngredeantsTableLayout.ColumnCount = 1;
            IngredeantsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            IngredeantsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            IngredeantsTableLayout.Controls.Add(IngredeantsLabel, 0, 0);
            IngredeantsTableLayout.Controls.Add(ingredeantsDataGridView, 0, 2);
            IngredeantsTableLayout.Dock = DockStyle.Fill;
            IngredeantsTableLayout.Location = new Point(23, 153);
            IngredeantsTableLayout.Name = "IngredeantsTableLayout";
            IngredeantsTableLayout.RowCount = 3;
            IngredeantsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            IngredeantsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            IngredeantsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            IngredeantsTableLayout.Size = new Size(384, 106);
            IngredeantsTableLayout.TabIndex = 1;
            // 
            // IngredeantsLabel
            // 
            IngredeantsLabel.AutoSize = true;
            IngredeantsLabel.Dock = DockStyle.Fill;
            IngredeantsLabel.Location = new Point(3, 0);
            IngredeantsLabel.Name = "IngredeantsLabel";
            IngredeantsLabel.Size = new Size(378, 20);
            IngredeantsLabel.TabIndex = 0;
            IngredeantsLabel.Text = "Ingredeants :";
            IngredeantsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ingredeantsDataGridView
            // 
            ingredeantsDataGridView.AllowUserToAddRows = false;
            ingredeantsDataGridView.AllowUserToDeleteRows = false;
            ingredeantsDataGridView.BackgroundColor = SystemColors.Control;
            ingredeantsDataGridView.BorderStyle = BorderStyle.None;
            ingredeantsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ingredeantsDataGridView.Columns.AddRange(new DataGridViewColumn[] { ingredeantColumn, mesurmentColumn, unitColumn });
            ingredeantsDataGridView.Dock = DockStyle.Fill;
            ingredeantsDataGridView.Location = new Point(3, 33);
            ingredeantsDataGridView.Name = "ingredeantsDataGridView";
            ingredeantsDataGridView.ReadOnly = true;
            ingredeantsDataGridView.RowHeadersWidth = 10;
            ingredeantsDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ingredeantsDataGridView.Size = new Size(378, 70);
            ingredeantsDataGridView.TabIndex = 1;
            // 
            // ingredeantColumn
            // 
            ingredeantColumn.HeaderText = "Ingredeant";
            ingredeantColumn.Name = "ingredeantColumn";
            ingredeantColumn.ReadOnly = true;
            // 
            // mesurmentColumn
            // 
            mesurmentColumn.HeaderText = "Mesurment";
            mesurmentColumn.Name = "mesurmentColumn";
            mesurmentColumn.ReadOnly = true;
            // 
            // unitColumn
            // 
            unitColumn.HeaderText = "Unit";
            unitColumn.Name = "unitColumn";
            unitColumn.ReadOnly = true;
            // 
            // instructionsTableLayout
            // 
            instructionsTableLayout.ColumnCount = 1;
            instructionsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            instructionsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            instructionsTableLayout.Controls.Add(instructionLabel, 0, 0);
            instructionsTableLayout.Controls.Add(instructiconTextBox, 0, 2);
            instructionsTableLayout.Dock = DockStyle.Fill;
            instructionsTableLayout.Location = new Point(23, 275);
            instructionsTableLayout.Name = "instructionsTableLayout";
            instructionsTableLayout.RowCount = 3;
            instructionsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            instructionsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            instructionsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            instructionsTableLayout.Size = new Size(384, 106);
            instructionsTableLayout.TabIndex = 2;
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Dock = DockStyle.Fill;
            instructionLabel.Location = new Point(3, 0);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(378, 20);
            instructionLabel.TabIndex = 0;
            instructionLabel.Text = "Instruction :";
            instructionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // instructiconTextBox
            // 
            instructiconTextBox.BackColor = SystemColors.Control;
            instructiconTextBox.BorderStyle = BorderStyle.None;
            instructiconTextBox.Dock = DockStyle.Fill;
            instructiconTextBox.Location = new Point(3, 33);
            instructiconTextBox.Name = "instructiconTextBox";
            instructiconTextBox.ReadOnly = true;
            instructiconTextBox.ScrollBars = ScrollBars.Vertical;
            instructiconTextBox.Size = new Size(378, 16);
            instructiconTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(finalMesureLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(finalMesureDataLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(finalMesureDataUnitLabel, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(23, 113);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(384, 29);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // finalMesureLabel
            // 
            finalMesureLabel.AutoSize = true;
            finalMesureLabel.Dock = DockStyle.Fill;
            finalMesureLabel.Location = new Point(3, 0);
            finalMesureLabel.Name = "finalMesureLabel";
            finalMesureLabel.Size = new Size(94, 29);
            finalMesureLabel.TabIndex = 0;
            finalMesureLabel.Text = "Final Mesure :";
            finalMesureLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // finalMesureDataLabel
            // 
            finalMesureDataLabel.AutoSize = true;
            finalMesureDataLabel.Dock = DockStyle.Fill;
            finalMesureDataLabel.Location = new Point(103, 0);
            finalMesureDataLabel.Name = "finalMesureDataLabel";
            finalMesureDataLabel.Size = new Size(74, 29);
            finalMesureDataLabel.TabIndex = 1;
            finalMesureDataLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // finalMesureDataUnitLabel
            // 
            finalMesureDataUnitLabel.AutoSize = true;
            finalMesureDataUnitLabel.Dock = DockStyle.Fill;
            finalMesureDataUnitLabel.Location = new Point(188, 0);
            finalMesureDataUnitLabel.Name = "finalMesureDataUnitLabel";
            finalMesureDataUnitLabel.Size = new Size(44, 29);
            finalMesureDataUnitLabel.TabIndex = 2;
            finalMesureDataUnitLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // updateButton
            // 
            updateButton.Dock = DockStyle.Fill;
            updateButton.Enabled = false;
            updateButton.Location = new Point(183, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(74, 23);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.Enabled = false;
            deleteButton.Location = new Point(273, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(74, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            IngredeantsTableLayout.ResumeLayout(false);
            IngredeantsTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ingredeantsDataGridView).EndInit();
            instructionsTableLayout.ResumeLayout(false);
            instructionsTableLayout.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel IngredeantsTableLayout;
        private Label IngredeantsLabel;
        private TableLayoutPanel instructionsTableLayout;
        private DataGridView ingredeantsDataGridView;
        private Label instructionLabel;
        private TextBox instructiconTextBox;
        private DataGridViewTextBoxColumn ingredeantColumn;
        private DataGridViewTextBoxColumn mesurmentColumn;
        private DataGridViewTextBoxColumn unitColumn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label finalMesureLabel;
        private Label finalMesureDataLabel;
        private Label finalMesureDataUnitLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label editLabel;
        private Button newRecipeButton;
        private Button updateButton;
        private Button deleteButton;
    }
}