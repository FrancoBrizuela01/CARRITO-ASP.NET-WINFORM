
namespace ProyectoPrograIII2021
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tbUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbConstraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.Location = new System.Drawing.Point(304, 301);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Primary = true;
            this.btnIngresar.Size = new System.Drawing.Size(181, 34);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Enabled = false;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(227, 181);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Usuario";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Enabled = false;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(227, 230);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Contraseña";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Depth = 0;
            this.tbUsuario.Hint = "";
            this.tbUsuario.Location = new System.Drawing.Point(335, 177);
            this.tbUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.PasswordChar = '\0';
            this.tbUsuario.SelectedText = "";
            this.tbUsuario.SelectionLength = 0;
            this.tbUsuario.SelectionStart = 0;
            this.tbUsuario.Size = new System.Drawing.Size(224, 23);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Text = "admin";
            this.tbUsuario.UseSystemPasswordChar = false;
            // 
            // tbConstraseña
            // 
            this.tbConstraseña.Depth = 0;
            this.tbConstraseña.Hint = "";
            this.tbConstraseña.Location = new System.Drawing.Point(335, 230);
            this.tbConstraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbConstraseña.Name = "tbConstraseña";
            this.tbConstraseña.PasswordChar = '*';
            this.tbConstraseña.SelectedText = "";
            this.tbConstraseña.SelectionLength = 0;
            this.tbConstraseña.SelectionStart = 0;
            this.tbConstraseña.Size = new System.Drawing.Size(224, 23);
            this.tbConstraseña.TabIndex = 1;
            this.tbConstraseña.Text = "123";
            this.tbConstraseña.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPrograIII2021.Properties.Resources.Captura_de_pantalla__30_1;
            this.pictureBox1.Location = new System.Drawing.Point(323, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 391);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbConstraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnIngresar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar al sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnIngresar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbConstraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

