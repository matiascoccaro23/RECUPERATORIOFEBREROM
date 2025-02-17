using PoligonoRegularApp;

namespace RECUPERATORIOFEBREROM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Label label1;
        private TextBox textBox1;

        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 26);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(73, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "txtLado";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 87);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad de lados:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "txtCantidadLados";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 147);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Color:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(211, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Tag = "";
            comboBox1.Text = "cboColor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 209);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 6;
            label4.Text = "Material:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(211, 201);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(135, 23);
            comboBox2.TabIndex = 7;
            comboBox2.Text = "cboMaterial";
            // 
            // button1
            // 
            button1.Location = new Point(57, 273);
            button1.Name = "button1";
            button1.Size = new Size(64, 30);
            button1.TabIndex = 8;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(211, 273);
            button2.Name = "button2";
            button2.Size = new Size(66, 30);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(796, 305);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label2;
        private TextBox textBox2;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPoligonos.SelectedRows.Count > 0)
            {
                var poligono = (PoligonoRegular)dgvPoligonos.SelectedRows[0].DataBoundItem;
                frmPoligonoAE editarForm = new frmPoligonoAE(poligono);
                if (editarForm.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un polígono para editar.");
            }
        }

        private PoligonoRegular poligono;

        public frmPoligonoAE (PoligonoRegular poligono)
        {
            InitializeComponent();
            this.poligono = poligono;
            CargarDatos();
        }

        private void CargarDatos()
        {
            txtLado.Text = poligono.Lado.ToString("F2");
            txtCantidadLados.Text = poligono.CantidadLados.ToString();
            cmbColor.SelectedItem = poligono.Color;
            cmbMaterial.SelectedItem = poligono.Material;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            poligono.Lado = double.Parse(txtLado.Text);
            poligono.CantidadLados = int.Parse(txtCantidadLados.Text);
            poligono.Color = (Color)cmbColor.SelectedItem;
            poligono.Material = (Material)cmbMaterial.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();
        }


    }
}

