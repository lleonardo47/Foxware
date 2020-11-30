namespace FoxTruck
{
    partial class Selecao_consulta
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
            this.btn_pesquisar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_consulta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.AutoSize = true;
            this.btn_pesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_pesquisar.Depth = 0;
            this.btn_pesquisar.Icon = null;
            this.btn_pesquisar.Location = new System.Drawing.Point(22, 187);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_pesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Primary = false;
            this.btn_pesquisar.Size = new System.Drawing.Size(94, 36);
            this.btn_pesquisar.TabIndex = 0;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click_1);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(189, 187);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(91, 36);
            this.materialFlatButton2.TabIndex = 1;
            this.materialFlatButton2.Text = "Cancelar";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione a consulta";
            // 
            // cb_consulta
            // 
            this.cb_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cb_consulta.FormattingEnabled = true;
            this.cb_consulta.Items.AddRange(new object[] {
            "Cliente",
            "Estoque",
            "Serviço",
            "Funcionário",
            "Ordem de serviço",
            "Veículo"});
            this.cb_consulta.Location = new System.Drawing.Point(22, 143);
            this.cb_consulta.Name = "cb_consulta";
            this.cb_consulta.Size = new System.Drawing.Size(258, 32);
            this.cb_consulta.TabIndex = 4;
            // 
            // Selecao_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 258);
            this.Controls.Add(this.cb_consulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.btn_pesquisar);
            this.MaximumSize = new System.Drawing.Size(310, 258);
            this.MinimumSize = new System.Drawing.Size(310, 258);
            this.Name = "Selecao_consulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btn_pesquisar;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_consulta;
    }
}