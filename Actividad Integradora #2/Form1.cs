using Actividad_Integradora__2.CLASES;
using Actividad_Integradora__2.CLASES.CLASE_VISTA;
using Actividad_Integradora__2.CLASES.EXCEPCIONES;
using Actividad_Integradora__2.CLASES.Comparadores.INVERSOR;
using Actividad_Integradora__2.CLASES.Comparadores.ACCION;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Actividad_Integradora__2
{
    public partial class Form1 : Form
    {
        #region Listas bindeadas
        private BindingList<Inversor> Inversores = new BindingList<Inversor>();
        private BindingList<Accion> Acciones = new BindingList<Accion>();
        private bool _ascendenteInversores = true;
        private bool _ascendenteAcciones = true;
        #endregion
        public Form1()
        {
            #region Configuracion de grillas
            InitializeComponent();
            dgvInversores.AutoGenerateColumns = false;
            dgvInversores.DataSource = Inversores;
            dgvInversores.SelectionChanged += DgvInversores_SelectionChanged;
            dgvInversores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInversores.ColumnHeaderMouseClick += DgvInversores_ColumnHeaderMouseClick;
            dgvInversores.MultiSelect = false;
            dgvInversores.ReadOnly = true;
            dgvInversores.AllowUserToAddRows = false;
            dgvInversores.AllowUserToDeleteRows = false;

            dgvAcciones.DataSource = Acciones;
            dgvAcciones.SelectionChanged += DgvAcciones_SelectionChanged;
            dgvAcciones.ColumnHeaderMouseClick += DgvAcciones_ColumnHeaderMouseClick;
            dgvAcciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcciones.MultiSelect = false;
            dgvAcciones.ReadOnly = true;
            dgvAcciones.AllowUserToAddRows = false;
            dgvAcciones.AllowUserToDeleteRows = false;

            dgvInversiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInversiones.MultiSelect = false;
            dgvInversiones.ReadOnly = true;
            dgvInversiones.AllowUserToAddRows = false;
            dgvInversiones.AllowUserToDeleteRows = false;
            #endregion
        }

        private void DgvAcciones_SelectionChanged(object? sender, EventArgs e)
        {
            #region Mostrar Codigo de la Accion
            int indice = dgvAcciones.CurrentRow?.Index ?? -1;
            if (indice < 0 || indice >= Acciones.Count) return;

            string partes = "";
            foreach (var parte in Acciones[indice])
            {
                partes += parte + " ";
            }
            lblCodigoPartes.Text = partes;
            #endregion
        }

        private void DgvInversores_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            #region Ordenamiento de Inversores
            var lista = Inversores.ToList();

            switch (e.ColumnIndex)
            {
                case 0:
                    var comparadorlegajo = new OrdenarPorLegajo { Ascendente = _ascendenteInversores };
                    lista.Sort(comparadorlegajo);
                    break;

                case 1:
                    var comparadornombre = new OrdenarPorNombre { Ascendente = _ascendenteInversores };
                    lista.Sort(comparadornombre);
                    break;
                case 2:
                    var comparadornapellido = new OrdenarPorApellido { Ascendente = _ascendenteInversores };
                    lista.Sort(comparadornapellido);
                    break;
                case 3:
                    var comparadorDNI = new OrdenarPorDNI { Ascendente = _ascendenteInversores };
                    lista.Sort(comparadorDNI);
                    break;
            }

            _ascendenteInversores = !_ascendenteInversores;
            Inversores.Clear();
            foreach (var i in lista) Inversores.Add(i);
            #endregion
        }

        private void DgvAcciones_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            #region Ordenamiento de Acciones
            var listaAcciones = Acciones.ToList();

            switch (e.ColumnIndex)
            {
                case 0:
                    var comparadorporcodigo = new OrdenarPorCodigo { Ascendente = _ascendenteAcciones };
                    listaAcciones.Sort(comparadorporcodigo);
                    break;

                case 1:
                    var comparadorpordenom = new OrdenarPorDenominacion { Ascendente = _ascendenteAcciones };
                    listaAcciones.Sort(comparadorpordenom);
                    break;

                case 2: // 
                    var comparadorporcot = new OrdenarPorCotizacion { Ascendente = _ascendenteAcciones };
                    listaAcciones.Sort(comparadorporcot);
                    break;

                case 3:
                    var comparadorporcantem = new OrdenarPorCantidadEmitida { Ascendente = _ascendenteAcciones };
                    listaAcciones.Sort(comparadorporcantem);
                    break;
            }
            _ascendenteAcciones = !_ascendenteAcciones;
            Acciones.Clear();
            foreach (var a in listaAcciones) Acciones.Add(a);
            #endregion
        }

        private void DgvInversores_SelectionChanged(object? sender, EventArgs e)
        {
            #region Grilla de Inversores
            int indice = dgvInversores.CurrentRow?.Index ?? -1;

            if (indice < 0 || indice >= Inversores.Count) dgvInversiones.DataSource = null;

            else
            {
                List<InversionVista> inversionVista = new List<InversionVista>();
                foreach (Inversion inversion in Inversores[indice].Inversiones)
                {
                    inversionVista.Add(new InversionVista(inversion));
                }
                dgvInversiones.DataSource = inversionVista;
            }
            #endregion
        }

        public void ActualizarGrillas()
        {
            #region Refrescar grillas
            dgvInversores.Refresh();
            dgvAcciones.Refresh();

            if (dgvInversores.Rows.Count > 0)
            {
                dgvInversores.Rows[0].Selected = true;
                dgvInversores.CurrentCell = dgvInversores.Rows[0].Cells[0];
            }
            else
            {
                dgvInversiones.DataSource = null;
            }

            ActualizarLabels();
            dgvInversores.ClearSelection();
            #endregion
        }
        public void ActualizarLabels()
        {
            #region Mostrar labels de comisiones y el total

            if (Inversores.Count == 0)
            {
                lblTotalInvertido.Text = "Total Invertido: $0,00";
                lblComisionComun.Text = "Comisiones Comunes: $0,00";
                lblComisionPremiumBase.Text = "Premium (Hasta $20k): $0,00";
                lblComisionPremiumExcedente.Text = "Premium (Excedente): $0,00";
                lblComisionTotal.Text = "Total Comisiones: $0,00";
                return;
            }

            int indice = dgvInversores.CurrentRow?.Index ?? -1;

            if (indice < 0 || indice >= Inversores.Count)
            {
                lblTotalInvertido.Text = "Total Invertido: $0,00";
            }
            else
            {
                lblTotalInvertido.Text = $"Total Invertido: {Inversores[indice].TotalInvertido.ToString("C2")}";
            }

            decimal comisionComun = Inversores.Where(i => i.Tipo == "Comun").Sum(i => i.ComisionCobrada);
            lblComisionComun.Text = $"Recaudación Comunes: {comisionComun.ToString("C2")}";

            decimal premiumBase = Inversores.OfType<InversorPremium>().Sum(p => p.ComisionHasta20000);
            lblComisionPremiumBase.Text = $"Premium (Base): {premiumBase.ToString("C2")}";

            decimal premiumExcedente = Inversores.OfType<InversorPremium>().Sum(p => p.ComisionSobre20000);
            lblComisionPremiumExcedente.Text = $"Premium (Excedente): {premiumExcedente.ToString("C2")}";

            decimal totalGral = Inversores.Sum(i => i.ComisionCobrada);
            lblComisionTotal.Text = $"Total Comisiones: {totalGral.ToString("C2")}";

            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnAgregarI_Click(object sender, EventArgs e)
        {
            #region Agregar Inversor
            Inversor inversor = null;
            try
            {
                string nombre = Interaction.InputBox("Ingrese el nombre del inversor: ");
                if (string.IsNullOrWhiteSpace(nombre)) throw new InversorInvalidoException("El nombre no puede estar vacío");

                string apellido = Interaction.InputBox("Ingrese el apellido del inversor: ");
                if (string.IsNullOrWhiteSpace(apellido)) throw new InversorInvalidoException("El apellido no puede estar vacío");

                string dni = Interaction.InputBox("Ingrese el DNI del inversor: ");
                if (!Information.IsNumeric(dni)) throw new DNIInvalidoException("El DNI debe contener solo números");

                string tipo = Interaction.InputBox("Ingrese el tipo de inversor:\n1 - Común\n2 - Premium");

                if (tipo == "1") inversor = new InversorComun(nombre, apellido, dni);
                else if (tipo == "2") inversor = new InversorPremium(nombre, apellido, dni);
                else throw new InversorInvalidoException("Tipo de inversor invalido");

                Inversores.Add(inversor);
                ActualizarGrillas();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void btnBorrarI_Click(object sender, EventArgs e)
        {
            #region Borrar Inversor
            try
            {
                if (Inversores.Count == 0) throw new InversorSeleccionadoException("No hay inversores para eliminar");

                int indice = dgvInversores.CurrentRow?.Index ?? -1;

                if (indice < 0 || indice >= Inversores.Count) throw new InversorSeleccionadoException("No hay inversor seleccionado");

                Inversores.RemoveAt(indice);
                ActualizarGrillas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void btnModificarI_Click(object sender, EventArgs e)
        {
            #region Modificar inversor
            try
            {
                if (Inversores.Count == 0) throw new InversorSeleccionadoException("No hay inversores para eliminar");

                int indice = dgvInversores.CurrentRow?.Index ?? -1;
                if (indice < 0 || indice >= Inversores.Count) throw new InversorSeleccionadoException("No hay inversor seleccionado");

                string nombre = Interaction.InputBox("Ingrese el nombre del inversor: ");
                if (string.IsNullOrWhiteSpace(nombre)) throw new InversorInvalidoException("El nombre no puede estar vacío");

                string apellido = Interaction.InputBox("Ingrese el apellido del inversor: ");
                if (string.IsNullOrWhiteSpace(apellido)) throw new InversorInvalidoException("El apellido no puede estar vacío");

                string dni = Interaction.InputBox("Ingrese el DNI del inversor: ");
                if (!Information.IsNumeric(dni)) throw new DNIInvalidoException("El DNI debe contener solo números");
                Inversores[indice].Nombre = nombre;
                Inversores[indice].Apellido = apellido;
                Inversores[indice].DNI = dni;

                Inversores.ResetItem(indice);
                ActualizarGrillas();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void btnAgregarA_Click(object sender, EventArgs e)
        {
            #region Agregar Accion
            Accion accion = null;
            try
            {
                string codigo = Interaction.InputBox("Ingrese el codigo de la accion: ");
                if (string.IsNullOrWhiteSpace(codigo)) throw new CodigoInvalidoException("El codigo no puede estar vacío");

                string denominacion = Interaction.InputBox("Ingrese la denominacion de la accion: ");
                if (string.IsNullOrWhiteSpace(denominacion)) throw new DenominacionInvalidaException("La denominacion no puede estar vacia");


                string cotizacionstr = Interaction.InputBox("Ingrese la cotizacion de la accion: ");
                if (!Information.IsNumeric(cotizacionstr)) throw new CotizacionInvalidaException("La cotizacion debe ser un numero");
                decimal cotizacion = decimal.Parse(cotizacionstr);

                string cantidad_emitidastr = Interaction.InputBox("Ingrese la cantidad emitida: ");
                if (!Information.IsNumeric(cantidad_emitidastr)) throw new CantidadInvalidaException("La cantidad debe ser un numero");
                int cantidad_emitida = int.Parse(cantidad_emitidastr);

                accion = new Accion(codigo, denominacion, cotizacion, cantidad_emitida);
                Acciones.Add(accion);
                ActualizarGrillas();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void btnBorrarA_Click(object sender, EventArgs e)
        {
            #region Borrar Accion

            try
            {
                if (Acciones.Count == 0) throw new AccionInvalidaException("No hay acciones para eliminar");

                int indice = dgvAcciones.CurrentRow?.Index ?? -1;

                if (indice < 0 || indice >= Acciones.Count) throw new AccionInvalidaException("No hay acciones seleccionadas");

                Acciones.RemoveAt(indice);
                ActualizarGrillas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion
        }

        private void btnModificarA_Click(object sender, EventArgs e)
        {
            #region Modificar Accion

            try
            {
                if (Acciones.Count == 0) throw new AccionInvalidaException("No hay acciones para eliminar");

                int indice = dgvAcciones.CurrentRow?.Index ?? -1;
                if (indice < 0 || indice >= Acciones.Count) throw new AccionInvalidaException("No hay acciones seleccionadas");


                string codigo = Interaction.InputBox("Ingrese el codigo de la accion: ");
                if (string.IsNullOrWhiteSpace(codigo)) throw new CodigoInvalidoException("El codigo no puede estar vacío");

                string denominacion = Interaction.InputBox("Ingrese la denominacion de la accion: ");
                if (string.IsNullOrWhiteSpace(denominacion)) throw new DenominacionInvalidaException("La denominacion no puede estar vacia");


                string cotizacionstr = Interaction.InputBox("Ingrese la cotizacion de la accion: ");
                if (!Information.IsNumeric(cotizacionstr)) throw new CotizacionInvalidaException("La cotizacion debe ser un numero");
                decimal cotizacion = decimal.Parse(cotizacionstr);

                string cantidad_emitidastr = Interaction.InputBox("Ingrese la cantidad emitida: ");
                if (!Information.IsNumeric(cantidad_emitidastr)) throw new CantidadInvalidaException("La cantidad debe ser un numero");
                int cantidad_emitida = int.Parse(cantidad_emitidastr);
                Acciones[indice].Codigo = codigo;
                Acciones[indice].Denominacion = denominacion;
                Acciones[indice].Cotizacion = cotizacion;
                Acciones[indice].Cantidad_Emitida = cantidad_emitida;

                Acciones.ResetItem(indice);
                ActualizarGrillas();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            #region Comprar Accion

            try
            {
                if (Acciones.Count == 0) throw new AccionInvalidaException("No hay acciones para comprar");
                if (Inversores.Count == 0) throw new InversorInvalidoException("No hay inversores para comprar");

                int indiceI = dgvInversores.CurrentRow?.Index ?? -1;

                if (indiceI < 0 || indiceI >= Inversores.Count) throw new InversorSeleccionadoException("No hay inversor seleccionado");
                int indiceA = dgvAcciones.CurrentRow?.Index ?? -1;
                if (indiceA < 0 || indiceA >= Acciones.Count) throw new AccionInvalidaException("No hay acciones seleccionadas");

                string cantidad_str = Interaction.InputBox("Ingrese la cantidad a comprar: ");
                if (!Information.IsNumeric(cantidad_str)) throw new CantidadInvalidaException("La cantidad debe ser un numero");
                int cantidad = int.Parse(cantidad_str);

                Inversores[indiceI].Comprar(Acciones[indiceA], cantidad);
                DgvInversores_SelectionChanged(null, EventArgs.Empty);
                ActualizarLabels();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            #region Vender Accion

            try
            {
                if (Acciones.Count == 0) throw new AccionInvalidaException("No hay acciones para vender");
                if (Inversores.Count == 0) throw new InversorInvalidoException("No hay inversores para vender");

                int indiceI = dgvInversores.CurrentRow?.Index ?? -1;

                if (indiceI < 0 || indiceI >= Inversores.Count) throw new InversorSeleccionadoException("No hay inversor seleccionado");
                int indiceA = dgvAcciones.CurrentRow?.Index ?? -1;
                if (indiceA < 0 || indiceA >= Acciones.Count) throw new AccionInvalidaException("No hay acciones seleccionadas");

                string cantidad_str = Interaction.InputBox("Ingrese la cantidad a vender: ");
                if (!Information.IsNumeric(cantidad_str)) throw new CantidadInvalidaException("La cantidad debe ser un numero");
                int cantidad = int.Parse(cantidad_str);

                Inversores[indiceI].Vender(Acciones[indiceA], cantidad);
                DgvInversores_SelectionChanged(null, EventArgs.Empty);
                ActualizarLabels();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }
    }
}