
namespace Farmacie
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
            this.buttonAdaugaMedicamente = new System.Windows.Forms.Button();
            this.buttonAfiseazaMedicamente = new System.Windows.Forms.Button();
            this.buttonCautare_Medicament = new System.Windows.Forms.Button();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.buttonIncarcare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelEroare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdaugaMedicamente
            // 
            this.buttonAdaugaMedicamente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdaugaMedicamente.Location = new System.Drawing.Point(21, 48);
            this.buttonAdaugaMedicamente.Name = "buttonAdaugaMedicamente";
            this.buttonAdaugaMedicamente.Size = new System.Drawing.Size(182, 34);
            this.buttonAdaugaMedicamente.TabIndex = 0;
            this.buttonAdaugaMedicamente.Text = "Adauga Medicamente";
            this.buttonAdaugaMedicamente.UseVisualStyleBackColor = false;
            this.buttonAdaugaMedicamente.Click += new System.EventHandler(this.buttonAdaugaMedicament_Click);
            // 
            // buttonAfiseazaMedicamente
            // 
            this.buttonAfiseazaMedicamente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAfiseazaMedicamente.Location = new System.Drawing.Point(21, 130);
            this.buttonAfiseazaMedicamente.Name = "buttonAfiseazaMedicamente";
            this.buttonAfiseazaMedicamente.Size = new System.Drawing.Size(182, 34);
            this.buttonAfiseazaMedicamente.TabIndex = 1;
            this.buttonAfiseazaMedicamente.Text = "Afiseaza Medicamente";
            this.buttonAfiseazaMedicamente.UseVisualStyleBackColor = false;
            this.buttonAfiseazaMedicamente.Click += new System.EventHandler(this.buttonAfiseazaMedicamente_Click);
            // 
            // buttonCautare_Medicament
            // 
            this.buttonCautare_Medicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCautare_Medicament.Location = new System.Drawing.Point(21, 206);
            this.buttonCautare_Medicament.Name = "buttonCautare_Medicament";
            this.buttonCautare_Medicament.Size = new System.Drawing.Size(182, 34);
            this.buttonCautare_Medicament.TabIndex = 2;
            this.buttonCautare_Medicament.Text = "Cautare Medicament";
            this.buttonCautare_Medicament.UseVisualStyleBackColor = false;
            this.buttonCautare_Medicament.Click += new System.EventHandler(this.buttonCauta_Medicament_Click);
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.BackColor = System.Drawing.Color.Teal;
            this.buttonSalvare.Location = new System.Drawing.Point(21, 288);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(182, 34);
            this.buttonSalvare.TabIndex = 3;
            this.buttonSalvare.Text = "Salvare Medicamente";
            this.buttonSalvare.UseVisualStyleBackColor = false;
            this.buttonSalvare.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // buttonIncarcare
            // 
            this.buttonIncarcare.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonIncarcare.Location = new System.Drawing.Point(21, 380);
            this.buttonIncarcare.Name = "buttonIncarcare";
            this.buttonIncarcare.Size = new System.Drawing.Size(182, 44);
            this.buttonIncarcare.TabIndex = 4;
            this.buttonIncarcare.Text = "Incarcare In Lista De Medicamente";
            this.buttonIncarcare.UseVisualStyleBackColor = false;
            this.buttonIncarcare.Click += new System.EventHandler(this.buttonIncarcare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(988, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelEroare
            // 
            this.labelEroare.AutoSize = true;
            this.labelEroare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEroare.Location = new System.Drawing.Point(463, 456);
            this.labelEroare.Name = "labelEroare";
            this.labelEroare.Size = new System.Drawing.Size(0, 37);
            this.labelEroare.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1144, 491);
            this.Controls.Add(this.labelEroare);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonIncarcare);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.buttonCautare_Medicament);
            this.Controls.Add(this.buttonAfiseazaMedicamente);
            this.Controls.Add(this.buttonAdaugaMedicamente);
            this.Name = "Form1";
            this.Text = "Farmacia La ANDRA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdaugaMedicamente;
        private System.Windows.Forms.Button buttonAfiseazaMedicamente;
        private System.Windows.Forms.Button buttonCautare_Medicament;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.Button buttonIncarcare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAdaugaNume;
        private System.Windows.Forms.TextBox textBoxNumeMedicament;
        private System.Windows.Forms.TextBox textBoxAgaudaCantitate;
        private System.Windows.Forms.Label labelAdaugaCantitate;
        private System.Windows.Forms.GroupBox groupBoxCategorievarsta;
        private System.Windows.Forms.RadioButton radioButtonVarstnici;
        private System.Windows.Forms.RadioButton radioButtonBebelusi;
        private System.Windows.Forms.RadioButton radiobuttonAdulti;
        private System.Windows.Forms.RadioButton radioButtonCopii;
        private System.Windows.Forms.CheckBox checkBoxStoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdaugaMed;
        private System.Windows.Forms.Label labelcauta;
        private System.Windows.Forms.TextBox textBoxCauta;
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.Label labelEroare;
    }
}

