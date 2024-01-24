namespace PROJET
{
    partial class Clients
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
            dataGridView1 = new DataGridView();
            RefreshBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            NomTxt = new TextBox();
            EmailTxt = new TextBox();
            TelTxt = new TextBox();
            PrenomTxt = new TextBox();
            AdresseTxt = new TextBox();
            IDTxt = new TextBox();
            ID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nom = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1092, 273);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(985, 52);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(128, 40);
            RefreshBtn.TabIndex = 1;
            RefreshBtn.Text = "Rafraichir";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(985, 232);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(128, 40);
            EditBtn.TabIndex = 4;
            EditBtn.Text = "Modifier";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(985, 169);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(128, 40);
            DeleteBtn.TabIndex = 5;
            DeleteBtn.Text = "Supprimer";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(985, 112);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(128, 40);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "Ajouter";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // NomTxt
            // 
            NomTxt.Location = new Point(213, 62);
            NomTxt.Name = "NomTxt";
            NomTxt.Size = new Size(203, 23);
            NomTxt.TabIndex = 7;
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(213, 199);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(203, 23);
            EmailTxt.TabIndex = 8;
            // 
            // TelTxt
            // 
            TelTxt.Location = new Point(213, 153);
            TelTxt.Name = "TelTxt";
            TelTxt.Size = new Size(203, 23);
            TelTxt.TabIndex = 9;
            TelTxt.TextChanged += TelTxt_TextChanged;
            // 
            // PrenomTxt
            // 
            PrenomTxt.Location = new Point(213, 106);
            PrenomTxt.Name = "PrenomTxt";
            PrenomTxt.Size = new Size(203, 23);
            PrenomTxt.TabIndex = 10;
            // 
            // AdresseTxt
            // 
            AdresseTxt.Location = new Point(213, 244);
            AdresseTxt.Name = "AdresseTxt";
            AdresseTxt.Size = new Size(203, 23);
            AdresseTxt.TabIndex = 11;
            // 
            // IDTxt
            // 
            IDTxt.Location = new Point(213, 21);
            IDTxt.Name = "IDTxt";
            IDTxt.Size = new Size(203, 23);
            IDTxt.TabIndex = 12;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(47, 29);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 13;
            ID.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 207);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 14;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 161);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 15;
            label3.Text = "Telephone";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 114);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 16;
            label4.Text = "Prenom";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(47, 70);
            Nom.Name = "Nom";
            Nom.Size = new Size(34, 15);
            Nom.TabIndex = 17;
            Nom.Text = "Nom";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 252);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 18;
            label6.Text = "Adresse";
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 624);
            Controls.Add(label6);
            Controls.Add(Nom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ID);
            Controls.Add(IDTxt);
            Controls.Add(AdresseTxt);
            Controls.Add(PrenomTxt);
            Controls.Add(TelTxt);
            Controls.Add(EmailTxt);
            Controls.Add(NomTxt);
            Controls.Add(AddBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(RefreshBtn);
            Controls.Add(dataGridView1);
            Name = "Clients";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button RefreshBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private TextBox NomTxt;
        private TextBox EmailTxt;
        private TextBox TelTxt;
        private TextBox PrenomTxt;
        private TextBox AdresseTxt;
        private TextBox IDTxt;
        private Label ID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Nom;
        private Label label6;
    }
}