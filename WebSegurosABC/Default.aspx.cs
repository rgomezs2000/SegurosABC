using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSegurosABC.ServicioSegurosABC;

namespace WebSegurosABC
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCedula.Text == "")
                {
                    lblInfo.Text = "Debes introducir el numero de cedula";
                }
                else
                {
                    CosultarPagosClientes(txtCedula.Text);
                }
            }
            catch
            {
                lblInfo.Text = "Error al consultar el servicio";
            }
        }

        public void CosultarPagosClientes(string cedulas)
        {
            ServicioSegurosABCClient clientes = new ServicioSegurosABCClient();
            Clientes[] cli = clientes.ConsultarPagoClientes(cedulas);

            TableRow rows;
            TableCell cells;

            TableHeaderRow tableHeaderRow = new TableHeaderRow();
            TableHeaderCell tableHeaderCell = new TableHeaderCell();
            tableHeaderCell.Text = "Cedula";
            tableHeaderCell.Scope = TableHeaderScope.Column;
            tableHeaderRow.Cells.Add(tableHeaderCell);

            tableHeaderCell = new TableHeaderCell();
            tableHeaderCell.Text = "Nombre";
            tableHeaderCell.Scope = TableHeaderScope.Column;
            tableHeaderRow.Cells.Add(tableHeaderCell);

            tableHeaderCell = new TableHeaderCell();
            tableHeaderCell.Text = "Fecha";
            tableHeaderCell.Scope = TableHeaderScope.Column;
            tableHeaderRow.Cells.Add(tableHeaderCell);

            tableHeaderCell = new TableHeaderCell();
            tableHeaderCell.Text = "Monto";
            tableHeaderCell.Scope = TableHeaderScope.Column;
            tableHeaderRow.Cells.Add(tableHeaderCell);

            foreach(Clientes cliente in cli)
            {
                rows = new TableRow();

                cells = new TableCell();
                cells.Text = cliente.cedula.ToString();
                rows.Cells.Add(cells);

                cells = new TableCell();
                cells.Text = cliente.nombre.ToString();
                rows.Cells.Add(cells);

                cells = new TableCell();
                cells.Text = cliente.fecha.ToString();
                rows.Cells.Add(cells);

                cells = new TableCell();
                cells.Text = cliente.monto.ToString();
                rows.Cells.Add(cells);

                tablaPagos.Rows.Add(rows);
            }
            

        }
    }
}