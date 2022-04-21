
namespace ProyectoPrograIII2021
{
    partial class VentaProducto
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tbCodProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbCantidadProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVender = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMenu = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbNumeroCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tbNombreCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(211, 208);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(145, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Codigo del producto";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(211, 252);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(128, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Cantidad a vender";
            // 
            // tbCodProducto
            // 
            this.tbCodProducto.Depth = 0;
            this.tbCodProducto.Hint = "";
            this.tbCodProducto.Location = new System.Drawing.Point(404, 208);
            this.tbCodProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCodProducto.Name = "tbCodProducto";
            this.tbCodProducto.PasswordChar = '\0';
            this.tbCodProducto.SelectedText = "";
            this.tbCodProducto.SelectionLength = 0;
            this.tbCodProducto.SelectionStart = 0;
            this.tbCodProducto.Size = new System.Drawing.Size(213, 23);
            this.tbCodProducto.TabIndex = 0;
            this.tbCodProducto.UseSystemPasswordChar = false;
            // 
            // tbCantidadProducto
            // 
            this.tbCantidadProducto.Depth = 0;
            this.tbCantidadProducto.Hint = "";
            this.tbCantidadProducto.Location = new System.Drawing.Point(404, 252);
            this.tbCantidadProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCantidadProducto.Name = "tbCantidadProducto";
            this.tbCantidadProducto.PasswordChar = '\0';
            this.tbCantidadProducto.SelectedText = "";
            this.tbCantidadProducto.SelectionLength = 0;
            this.tbCantidadProducto.SelectionStart = 0;
            this.tbCantidadProducto.Size = new System.Drawing.Size(213, 23);
            this.tbCantidadProducto.TabIndex = 1;
            this.tbCantidadProducto.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPrograIII2021.Properties.Resources.Captura_de_pantalla__30_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnVender
            // 
            this.btnVender.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.AutoSize = true;
            this.btnVender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVender.BackColor = System.Drawing.SystemColors.Control;
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.Depth = 0;
            this.btnVender.Location = new System.Drawing.Point(367, 391);
            this.btnVender.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVender.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVender.Name = "btnVender";
            this.btnVender.Primary = false;
            this.btnVender.Size = new System.Drawing.Size(64, 36);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click_1);
            // 
            // btnMenu
            // 
            this.btnMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnMenu.AutoSize = true;
            this.btnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Depth = 0;
            this.btnMenu.Location = new System.Drawing.Point(710, 81);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Primary = false;
            this.btnMenu.Size = new System.Drawing.Size(125, 36);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Volver al menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(211, 337);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(132, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Numero de cliente";
            // 
            // tbNumeroCliente
            // 
            this.tbNumeroCliente.Depth = 0;
            this.tbNumeroCliente.Hint = "";
            this.tbNumeroCliente.Location = new System.Drawing.Point(404, 337);
            this.tbNumeroCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbNumeroCliente.Name = "tbNumeroCliente";
            this.tbNumeroCliente.PasswordChar = '\0';
            this.tbNumeroCliente.SelectedText = "";
            this.tbNumeroCliente.SelectionLength = 0;
            this.tbNumeroCliente.SelectionStart = 0;
            this.tbNumeroCliente.Size = new System.Drawing.Size(213, 23);
            this.tbNumeroCliente.TabIndex = 12;
            this.tbNumeroCliente.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(211, 295);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(136, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Nombre del cliente";
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Depth = 0;
            this.tbNombreCliente.Hint = "";
            this.tbNombreCliente.Location = new System.Drawing.Point(404, 295);
            this.tbNombreCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.PasswordChar = '\0';
            this.tbNombreCliente.SelectedText = "";
            this.tbNombreCliente.SelectionLength = 0;
            this.tbNombreCliente.SelectionStart = 0;
            this.tbNombreCliente.Size = new System.Drawing.Size(213, 23);
            this.tbNombreCliente.TabIndex = 14;
            this.tbNombreCliente.UseSystemPasswordChar = false;
            // 
            // VentaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 520);
            this.Controls.Add(this.tbNombreCliente);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.tbNumeroCliente);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbCantidadProducto);
            this.Controls.Add(this.tbCodProducto);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "VentaProducto";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de producto";
            this.Load += new System.EventHandler(this.VentaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCodProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCantidadProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnVender;
        private MaterialSkin.Controls.MaterialFlatButton btnMenu;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbNumeroCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbNombreCliente;
    }
}