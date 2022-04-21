
namespace ProyectoPrograIII2021
{
    partial class Menu
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClientes = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnComprarProducto = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVenderProducto = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminarProducto = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBuscarProducto = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAltaProducto = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalirDeSistema = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnClientes, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnComprarProducto, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnVenderProducto, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEliminarProducto, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscarProducto, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAltaProducto, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 85);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66933F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(216, 404);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSize = true;
            this.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Depth = 0;
            this.btnClientes.Location = new System.Drawing.Point(5, 342);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Primary = false;
            this.btnClientes.Size = new System.Drawing.Size(156, 36);
            this.btnClientes.TabIndex = 10;
            this.btnClientes.Text = "Historial de ventas";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnComprarProducto
            // 
            this.btnComprarProducto.AutoSize = true;
            this.btnComprarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnComprarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprarProducto.Depth = 0;
            this.btnComprarProducto.Location = new System.Drawing.Point(5, 275);
            this.btnComprarProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnComprarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnComprarProducto.Name = "btnComprarProducto";
            this.btnComprarProducto.Primary = false;
            this.btnComprarProducto.Size = new System.Drawing.Size(152, 36);
            this.btnComprarProducto.TabIndex = 9;
            this.btnComprarProducto.Text = "Comprar producto";
            this.btnComprarProducto.UseVisualStyleBackColor = true;
            this.btnComprarProducto.Click += new System.EventHandler(this.btnComprarProducto_Click);
            // 
            // btnVenderProducto
            // 
            this.btnVenderProducto.AutoSize = true;
            this.btnVenderProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVenderProducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnVenderProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenderProducto.Depth = 0;
            this.btnVenderProducto.Location = new System.Drawing.Point(5, 7);
            this.btnVenderProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVenderProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVenderProducto.Name = "btnVenderProducto";
            this.btnVenderProducto.Primary = false;
            this.btnVenderProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVenderProducto.Size = new System.Drawing.Size(159, 36);
            this.btnVenderProducto.TabIndex = 0;
            this.btnVenderProducto.Text = "Venta de productos";
            this.btnVenderProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenderProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVenderProducto.UseVisualStyleBackColor = false;
            this.btnVenderProducto.Click += new System.EventHandler(this.btnVenderProducto_Click_1);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.AutoSize = true;
            this.btnEliminarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.Depth = 0;
            this.btnEliminarProducto.Location = new System.Drawing.Point(5, 208);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Primary = false;
            this.btnEliminarProducto.Size = new System.Drawing.Size(201, 36);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "Eliminación de productos";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click_1);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.AutoSize = true;
            this.btnBuscarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.Depth = 0;
            this.btnBuscarProducto.Location = new System.Drawing.Point(5, 141);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Primary = false;
            this.btnBuscarProducto.Size = new System.Drawing.Size(186, 36);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "Busqueda de productos";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click_1);
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.AutoSize = true;
            this.btnAltaProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAltaProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaProducto.Depth = 0;
            this.btnAltaProducto.Location = new System.Drawing.Point(5, 74);
            this.btnAltaProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAltaProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Primary = false;
            this.btnAltaProducto.Size = new System.Drawing.Size(149, 36);
            this.btnAltaProducto.TabIndex = 1;
            this.btnAltaProducto.Text = "Alta de productos";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click_1);
            // 
            // btnSalirDeSistema
            // 
            this.btnSalirDeSistema.AutoSize = true;
            this.btnSalirDeSistema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirDeSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalirDeSistema.Depth = 0;
            this.btnSalirDeSistema.Location = new System.Drawing.Point(682, 469);
            this.btnSalirDeSistema.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalirDeSistema.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirDeSistema.Name = "btnSalirDeSistema";
            this.btnSalirDeSistema.Primary = false;
            this.btnSalirDeSistema.Size = new System.Drawing.Size(138, 36);
            this.btnSalirDeSistema.TabIndex = 4;
            this.btnSalirDeSistema.Text = "SALIR DEL SISTEMA";
            this.btnSalirDeSistema.UseVisualStyleBackColor = false;
            this.btnSalirDeSistema.Click += new System.EventHandler(this.btnSalirDeSistema_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPrograIII2021.Properties.Resources.Captura_de_pantalla__30_;
            this.pictureBox1.Location = new System.Drawing.Point(278, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnSalirDeSistema);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialFlatButton btnVenderProducto;
        private MaterialSkin.Controls.MaterialFlatButton btnAltaProducto;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarProducto;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminarProducto;
        private MaterialSkin.Controls.MaterialFlatButton btnSalirDeSistema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnComprarProducto;
        private MaterialSkin.Controls.MaterialFlatButton btnClientes;
    }
}