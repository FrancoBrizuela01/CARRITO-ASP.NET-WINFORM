
namespace ProyectoPrograIII2021
{
    partial class Alta_de_producto
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tbDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbCodigoProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbCodigoProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAgregarProducto = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMenu = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPrograIII2021.Properties.Resources.Captura_de_pantalla__30_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(223, 152);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Descripción";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(223, 198);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(141, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Codigo de producto";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(222, 244);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 19);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Precio";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(222, 292);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(148, 19);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Codigo de proveedor";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(222, 337);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(48, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Stock";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Depth = 0;
            this.tbDescripcion.Hint = "";
            this.tbDescripcion.Location = new System.Drawing.Point(395, 152);
            this.tbDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.PasswordChar = '\0';
            this.tbDescripcion.SelectedText = "";
            this.tbDescripcion.SelectionLength = 0;
            this.tbDescripcion.SelectionStart = 0;
            this.tbDescripcion.Size = new System.Drawing.Size(228, 23);
            this.tbDescripcion.TabIndex = 19;
            this.tbDescripcion.UseSystemPasswordChar = false;
            // 
            // tbCodigoProducto
            // 
            this.tbCodigoProducto.Depth = 0;
            this.tbCodigoProducto.Hint = "";
            this.tbCodigoProducto.Location = new System.Drawing.Point(395, 198);
            this.tbCodigoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCodigoProducto.Name = "tbCodigoProducto";
            this.tbCodigoProducto.PasswordChar = '\0';
            this.tbCodigoProducto.SelectedText = "";
            this.tbCodigoProducto.SelectionLength = 0;
            this.tbCodigoProducto.SelectionStart = 0;
            this.tbCodigoProducto.Size = new System.Drawing.Size(228, 23);
            this.tbCodigoProducto.TabIndex = 20;
            this.tbCodigoProducto.UseSystemPasswordChar = false;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Depth = 0;
            this.tbPrecio.Hint = "";
            this.tbPrecio.Location = new System.Drawing.Point(395, 244);
            this.tbPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.PasswordChar = '\0';
            this.tbPrecio.SelectedText = "";
            this.tbPrecio.SelectionLength = 0;
            this.tbPrecio.SelectionStart = 0;
            this.tbPrecio.Size = new System.Drawing.Size(228, 23);
            this.tbPrecio.TabIndex = 21;
            this.tbPrecio.UseSystemPasswordChar = false;
            // 
            // tbStock
            // 
            this.tbStock.Depth = 0;
            this.tbStock.Hint = "";
            this.tbStock.Location = new System.Drawing.Point(395, 337);
            this.tbStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbStock.Name = "tbStock";
            this.tbStock.PasswordChar = '\0';
            this.tbStock.SelectedText = "";
            this.tbStock.SelectionLength = 0;
            this.tbStock.SelectionStart = 0;
            this.tbStock.Size = new System.Drawing.Size(228, 23);
            this.tbStock.TabIndex = 22;
            this.tbStock.UseSystemPasswordChar = false;
            // 
            // tbCodigoProveedor
            // 
            this.tbCodigoProveedor.Depth = 0;
            this.tbCodigoProveedor.Hint = "";
            this.tbCodigoProveedor.Location = new System.Drawing.Point(395, 292);
            this.tbCodigoProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCodigoProveedor.Name = "tbCodigoProveedor";
            this.tbCodigoProveedor.PasswordChar = '\0';
            this.tbCodigoProveedor.SelectedText = "";
            this.tbCodigoProveedor.SelectionLength = 0;
            this.tbCodigoProveedor.SelectionStart = 0;
            this.tbCodigoProveedor.Size = new System.Drawing.Size(228, 23);
            this.tbCodigoProveedor.TabIndex = 23;
            this.tbCodigoProveedor.UseSystemPasswordChar = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.AutoSize = true;
            this.btnAgregarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.Depth = 0;
            this.btnAgregarProducto.Location = new System.Drawing.Point(323, 411);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Primary = false;
            this.btnAgregarProducto.Size = new System.Drawing.Size(149, 36);
            this.btnAgregarProducto.TabIndex = 24;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click_1);
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Depth = 0;
            this.btnMenu.Location = new System.Drawing.Point(710, 83);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Primary = false;
            this.btnMenu.Size = new System.Drawing.Size(125, 36);
            this.btnMenu.TabIndex = 25;
            this.btnMenu.Text = "Volver al menú";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // Alta_de_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 520);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.tbCodigoProveedor);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbCodigoProducto);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Alta_de_producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de producto";
            this.Load += new System.EventHandler(this.Alta_de_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCodigoProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbPrecio;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCodigoProveedor;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarProducto;
        private MaterialSkin.Controls.MaterialFlatButton btnMenu;
    }
}