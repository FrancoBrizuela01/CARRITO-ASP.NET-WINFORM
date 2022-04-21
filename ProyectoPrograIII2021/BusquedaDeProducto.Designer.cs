
namespace ProyectoPrograIII2021
{
    partial class BusquedaDeProducto
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
            this.btnMenu = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBuscarProducto = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbCodigoProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnMenu.AutoSize = true;
            this.btnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Depth = 0;
            this.btnMenu.Location = new System.Drawing.Point(710, 84);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Primary = false;
            this.btnMenu.Size = new System.Drawing.Size(125, 36);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Text = "Volver al menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProducto.AutoSize = true;
            this.btnBuscarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarProducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.Depth = 0;
            this.btnBuscarProducto.Location = new System.Drawing.Point(330, 343);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Primary = false;
            this.btnBuscarProducto.Size = new System.Drawing.Size(139, 36);
            this.btnBuscarProducto.TabIndex = 13;
            this.btnBuscarProducto.Text = "Buscar producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPrograIII2021.Properties.Resources.Captura_de_pantalla__30_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tbCodigoProducto
            // 
            this.tbCodigoProducto.Depth = 0;
            this.tbCodigoProducto.Hint = "";
            this.tbCodigoProducto.Location = new System.Drawing.Point(415, 239);
            this.tbCodigoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCodigoProducto.Name = "tbCodigoProducto";
            this.tbCodigoProducto.PasswordChar = '\0';
            this.tbCodigoProducto.SelectedText = "";
            this.tbCodigoProducto.SelectionLength = 0;
            this.tbCodigoProducto.SelectionStart = 0;
            this.tbCodigoProducto.Size = new System.Drawing.Size(213, 23);
            this.tbCodigoProducto.TabIndex = 11;
            this.tbCodigoProducto.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(224, 239);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(145, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Codigo del producto";
            // 
            // BusquedaDeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 520);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbCodigoProducto);
            this.Controls.Add(this.materialLabel1);
            this.Name = "BusquedaDeProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusquedaDeProducto";
            this.Load += new System.EventHandler(this.BusquedaDeProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnMenu;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCodigoProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}