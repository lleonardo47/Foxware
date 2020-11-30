namespace FoxTruck
{
    partial class Selecao_cadastro
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
            this.cb_consulta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_pesquisar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // cb_consulta
            // 
            this.cb_consulta.FormattingEnabled = true;
            this.cb_consulta.Items.AddRange(new object[] {
            "Cliente",
            "Estoque",
            "Serviço",
            "Funcionário",
            "Veículo"});
            this.cb_consulta.Location = new System.Drawing.Point(12, 141);
            this.cb_consulta.Name = "cb_consulta";
            this.cb_consulta.Size = new System.Drawing.Size(258, 21);
            this.cb_consulta.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione o cadastro";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(179, 185);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(91, 36);
            this.materialFlatButton2.TabIndex = 6;
            this.materialFlatButton2.Text = "Cancelar";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.AutoSize = true;
            this.btn_pesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_pesquisar.Depth = 0;
            this.btn_pesquisar.Icon = null;
            this.btn_pesquisar.Location = new System.Drawing.Point(12, 185);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_pesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Primary = false;
            this.btn_pesquisar.Size = new System.Drawing.Size(94, 36);
            this.btn_pesquisar.TabIndex = 5;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // Selecao_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 229);
            this.Controls.Add(this.cb_consulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.btn_pesquisar);
            this.Name = "Selecao_cadastro";
            this.Text = "Cadastro - selecao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_consulta;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton btn_pesquisar;
    }
}