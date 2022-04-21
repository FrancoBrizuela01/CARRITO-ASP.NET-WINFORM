
namespace ProyectoPrograIII2021
{
    partial class EliminarProducto
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
            this.btnEliminarProducto = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbProductoAEliminar = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.btnMenu.Location = new System.Drawing.Point(710, 85);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Primary = false;
            this.btnMenu.Size = new System.Drawing.Size(125, 36);
            this.btnMenu.TabIndex = 20;
            this.btnMenu.Text = "Volver al menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnEliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarProducto.AutoSize = true;
            this.btnEliminarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarProducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.Depth = 0;
            this.btnEliminarProducto.Location = new System.Drawing.Point(330, 344);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Primary = false;
            this.btnEliminarProducto.Size = new System.Drawing.Size(149, 36);
            this.btnEliminarProducto.TabIndex = 19;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPrograIII2021.Properties.Resources.Captura_de_pantalla__30_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // tbProductoAEliminar
            // 
            this.tbProductoAEliminar.Depth = 0;
            this.tbProductoAEliminar.Hint = "";
            this.tbProductoAEliminar.Location = new System.Drawing.Point(415, 240);
            this.tbProductoAEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbProductoAEliminar.Name = "tbProductoAEliminar";
            this.tbProductoAEliminar.PasswordChar = '\0';
            this.tbProductoAEliminar.SelectedText = "";
            this.tbProductoAEliminar.SelectionLength = 0;
            this.tbProductoAEliminar.SelectionStart = 0;
            this.tbProductoAEliminar.Size = new System.Drawing.Size(213, 23);
            this.tbProductoAEliminar.TabIndex = 18;
            this.tbProductoAEliminar.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(224, 240);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(145, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Codigo del producto";
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 520);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbProductoAEliminar);
            this.Controls.Add(this.materialLabel1);
            this.Name = "EliminarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Producto";
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnMenu;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminarProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbProductoAEliminar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}