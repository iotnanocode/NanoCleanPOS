using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;
using System.Drawing;
//PARA LA FUENTE
using System.Reflection;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Text;
namespace POS.Aux
{
    public struct Permisos
    {
        public string User;
        public DataTable dtPermisos;
    }

    public class FuncionesComunes
    {

        public bool Principal;
        public SmtpClient smtp;
        public const string MailRecibeInv = "finances.management@at-solutions.com.mx";
        public const string MailEnviaInv = "invoices@at-solutions.com.mx";
        public FuncionesComunes()
        {
            Principal = false;
            smtp = new SmtpClient("mail.at-solutions.com.mx", 587);
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("invoices@at-solutions.com.mx", "atsolvo");
        }
        public void ValidarPermisos(Form _Form, Permisos _Perm)
        {
            Form f = _Form;
            Permisos Perm = _Perm;

            if (Perm.dtPermisos.Select("Modulo ='TD'").Length > 0)
            {
                return;
            }
            foreach (Control c in f.Controls)
            {
                ValidaControl(c, Perm);
            }
        }

        public void ValidarPermisos(Form _Form, Permisos _Perm, bool _Principal)
        {
            Principal = true;
            ValidarPermisos(_Form, _Perm);
        }
        private void ValidaPanel(TableLayoutPanel tl, Permisos _Perm)
        {
            Permisos Perm = _Perm;
            foreach (Control c in tl.Controls)
            {
                if (c is TableLayoutPanel)
                {
                    ValidaPanel((TableLayoutPanel)c, Perm);
                }
                ValidaControl(c, Perm);

            }
        }

        private void ValidaPanelOrdinario(Panel tl, Permisos _Perm)
        {
            Permisos Perm = _Perm;
            foreach (Control c in tl.Controls)
            {
                if (c is Panel)
                {
                    ValidaPanelOrdinario((Panel)c, Perm);
                }
                ValidaControl(c, Perm);

            }
        }
        private void ValidaControl(Control c, Permisos _Perm)
        {
            Permisos Perm = _Perm;
            if (c is DevExpress.XtraBars.Ribbon.RibbonControl)
            {
                ValidaRibbon((DevExpress.XtraBars.Ribbon.RibbonControl)c, Perm);
            }
            if (c is Panel)
            {
                ValidaPanelOrdinario((Panel)c, Perm);
            }
            if (c is TableLayoutPanel)
            {
                ValidaPanel((TableLayoutPanel)c, Perm);
            }
            if (c is ToolStrip)
            {
                if (c.Tag != null)
                {
                    c.Visible = Perm.dtPermisos.Select("Modulo ='" + c.Tag.ToString() + "'").Length > 0 ? true : false;
                    if (!Principal)
                    {
                        c.Enabled = Perm.dtPermisos.Select("Modulo ='" + c.Tag.ToString() + "' AND Escritura=1").Length > 0 ? true : false;
                    }
                }
                ToolStrip t = (ToolStrip)c;
                foreach (ToolStripItem i in t.Items)
                {
                    if (i.Tag != null)
                    {
                        i.Visible = Perm.dtPermisos.Select("Modulo ='" + i.Tag.ToString() + "'").Length > 0 ? true : false;
                        if (!Principal)
                        {
                            i.Enabled = Perm.dtPermisos.Select("Modulo ='" + i.Tag.ToString() + "' AND Escritura=1").Length > 0 ? true : false;
                        }
                    }
                }
            }
        }

        void ValidaRibbon(DevExpress.XtraBars.Ribbon.RibbonControl r, Permisos Perm)
        {
            ValidaTabs(r, Perm);
            foreach (Object c in r.Items)
            {
                if (c is DevExpress.XtraBars.BarButtonItem)
                {
                    DevExpress.XtraBars.BarButtonItem b = (DevExpress.XtraBars.BarButtonItem)c;
                    try
                    {
                        if (b.Tag != null)
                        {
                            b.Visibility = Perm.dtPermisos.Select("Modulo ='" + b.Tag.ToString() + "'").Length > 0 ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
                            if (!Principal)
                            {
                                b.Enabled = Perm.dtPermisos.Select("Modulo ='" + b.Tag.ToString() + "' AND Escritura=1").Length > 0 ? true : false;
                            }
                        }
                    }
                    catch (Exception) { }
                }
            }
        }
        void ValidaTabs(DevExpress.XtraBars.Ribbon.RibbonControl r, Permisos Perm)
        {
            foreach (DevExpress.XtraBars.Ribbon.RibbonPage c in r.Pages)
            {
                if (c.Tag != null)
                {
                    c.Visible = Perm.dtPermisos.Select("Modulo ='" + c.Tag.ToString() + "'").Length > 0 ? true : false;
                }
            }
        }
        public void ValidaTxtInt(TextBox t)
        {
            try
            {
                Int32.Parse(t.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el campo: " + t.AccessibleName, "El valor Debería ser un numero entero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }
        public void ValidaTxtFloat(TextBox t)
        {
            try
            {
                float.Parse(t.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el campo: " + t.AccessibleName, "El valor Debería ser un numero real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }
        public void ValidaTxtFloat(DevExpress.XtraEditors.TextEdit t)
        {
            try
            {
                float.Parse(t.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el campo: " + t.AccessibleName, "El valor Debería ser un numero real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }
        public void ValidaTxtNull(TextBox t)
        {
            if (t.Text == "")
            {
                MessageBox.Show("Error en el campo: " + t.AccessibleName, "El valor no puede estar vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }
        public void ValidaTxtNull(DevExpress.XtraEditors.TextEdit t)
        {
            if (t.Text == "")
            {
                MessageBox.Show("Error en el campo: " + t.Properties.Name, "El valor no puede estar vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }
        public void ValidaCombo(ComboBox c)
        {
            if (c.SelectedValue == null)
            {
                MessageBox.Show("Error en el campo: " + c.AccessibleName, "Debe seleccionar un valor del combo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }
        public void ValidaCombo(DevExpress.XtraEditors.LookUpEdit c)
        {
            if (c.EditValue == null)
            {
                MessageBox.Show("Error en el campo: " + c.Properties.AccessibleName, "Debe seleccionar un valor del combo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }
        public void ValidaCombo(DevExpress.XtraEditors.SearchLookUpEdit c)
        {
            if (c.EditValue == null)
            {
                MessageBox.Show("Error en el campo: " + c.Properties.AccessibleName, "Debe seleccionar un valor del combo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }


        public void ValidaLookUp(DevExpress.XtraEditors.LookUpEdit c)
        {
            if (c.EditValue==null)
            {
                MessageBox.Show("Error en el campo: " + c.Properties.AccessibleName, "Debe seleccionar un valor del combo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }
        public void ValidaLookUp(DevExpress.XtraBars.BarEditItem c)
        {
            if (c.EditValue==null)
            {
                MessageBox.Show("Error en el campo: " + c.AccessibleName, "Debe seleccionar un valor del combo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }

        public void ValidaLookUp(DevExpress.XtraEditors.GridLookUpEdit c)
        {
            if (c.EditValue == null)
            {
                MessageBox.Show("Error en el campo: " + c.Properties.AccessibleName, "Debe seleccionar un valor del combo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }

                public void ValidaCombo(DevExpress.XtraEditors.GridLookUpEdit c)
        {
            if (c.EditValue == null)
            {
                MessageBox.Show("Error en el campo: " + c.Properties.AccessibleName, "Debe seleccionar un valor del combo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }
        public void ValidaDateEdit(DevExpress.XtraEditors.DateEdit c)
        {
            if (c.EditValue == null)
            {
                MessageBox.Show("Error en el campo: " + c.Properties.AccessibleName, "Debe seleccionar una fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }
        public void ValidaDateEdit(DateTimePicker c)
        {
            if (c.Value == null)
            {
                MessageBox.Show("Error en el campo: " + c.AccessibleName, "Debe seleccionar una fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }
        public void ValidaCampExistente(string Texto, string Campo, string Tabla)
        {
            AccessConeccion ac = new AccessConeccion();
            string cmd = "SELECT COUNT(ID) FROM " + Tabla + " WHERE " + Campo + "='" + Texto.Replace("-", "").Replace(" ", "").ToUpper() + "' AND Activo=-1";

            int cont = (int)ac.ExecutaEscalar(cmd);

            if (Texto.ToUpper() == "XAXX010101000" || Texto.ToUpper() == "XAXX010101000")
                return;
            if (cont > 0)
            {
                MessageBox.Show("Error en el campo: " + Campo, "El valor no se puede repetir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException("Formato incorrecto");
            }
        }
        public DialogResult ValidaClienteExistente(string Texto,int Comp)
        {
            AccessConeccion ac = new AccessConeccion();
            string cmd = "SELECT COUNT(ID) FROM Clientes WHERE [Comp]="+Comp+"AND RFC='" + Texto.Replace("-", "").Replace(" ", "").ToUpper() + "' AND Activo=-1";

            int cont = (int)ac.ExecutaEscalar(cmd);

            if (Texto.ToUpper() == "XAXX010101000" || Texto.ToUpper() == "XAXX010101000")
                return DialogResult.Yes;
            if (cont > 0)
            {
                return MessageBox.Show("Ese cliente ya esta registrado, lo quiere duplicar?", "RC Repetido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //throw new FormatException("Formato incorrecto");
            }
            return DialogResult.Yes;
        }
        public void EnviaCorreoInventario(int IDProducto)
        {
            string cmd = "SELECT        Producto, Descripcion, SUM(Cantidad) AS Cantidad, MAX(Minimo) Minimo " +
                        "FROM            inv.rwExistencias " +
                        "WHERE IDProducto =" + IDProducto + " " +
                        "GROUP BY Producto, Descripcion ";
            string Parte, Descripcion, Cantidad, Minimo;
            Parte = "";
            Descripcion = "";
            Cantidad = "";
            Minimo = "";
            AccessConeccion ac = new AccessConeccion();
            DataTable dt = ac.ObtieneTabla(cmd);
            foreach (DataRow r in dt.Rows)
            {
                Parte = r["Producto"].ToString();
                Descripcion = r["Descripcion"].ToString();
                Cantidad = r["Cantidad"].ToString();
                Minimo = r["Minimo"].ToString();
                break;
            }
            int ICant, IMin;
            ICant = Int32.Parse(Cantidad);
            IMin=Int32.Parse(Minimo);
            if (ICant > IMin) // en este caso no es necesario enviar correo
            {
                return;
            }
            string Body = "Hola, La siguiente Parte ha alcanzado su inventario mínimo, a continuación la información:<br>" +
						"<br><b>Producto:    </b>" + Parte  + 
						"<br><b>Descripcion:    </b>" + Descripcion +	 
						"<br><b>Cantidad en Existencia:    </b>" + Cantidad  +	
						"<br><b>Mínimo para el producto:    </b>" + Minimo  +
						"<br><br><br><br>"+
						"<b>Gracias por su atención</b>";
            MailMessage m = new MailMessage(MailEnviaInv, MailRecibeInv, "Producto en inventario Mínimo", Body);
            m.IsBodyHtml = true;
            try
            {
                smtp.Send(m);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,"No se pudo enviar correo de inventario minimo",MessageBoxButtons.OK);
            }

        }
        public string TitleCaseString(String s)
        {
            if (s == null) return s;

            String[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0) continue;

                Char firstChar = Char.ToUpper(words[i][0]);
                String rest = "";
                if (words[i].Length > 1)
                {
                    rest = words[i].Substring(1).ToLower();
                }
                words[i] = firstChar + rest;
            }
            return String.Join(" ", words);
        }
        public byte[] GetBytesFromFile(string fullFilePath)
        {
            // this method is limited to 2^32 byte files (4.2 GB)

            FileStream fs = null;
            try
            {
                fs = File.OpenRead(fullFilePath);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
                return bytes;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }
        }
        public byte[] GetBytesImage(PictureBox FotoPick)
        {
            Byte[] Imagen;
            MemoryStream ms = new MemoryStream();
            Image i = FotoPick.Image;
            i.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            Imagen = ms.ToArray();
            return Imagen;
        }
        
        public Image GetImageFromBites(object Datos)
        {
            
            //LLENADO DE LA FOTOGRAFIA
            Image foto = null;
            try
            {
                Stream s = new MemoryStream((byte[])Datos);
                foto = Image.FromStream(s);
            }
            catch (Exception) 
            {
                foto = null; 
            }
            return foto;
        }
        public bool GetBoolValue(object ValueFromBD)
        {
            return ValueFromBD.ToString() == "1";
        }
        public int GetBoolValue(DevExpress.XtraEditors.ToggleSwitch toggleSwitch)
        {
            return (bool)toggleSwitch.EditValue ? 1 : 0;
        }
        public int GetBoolValue(DevExpress.XtraEditors.RadioGroup RadioGroup)
        {
            return (bool)RadioGroup.EditValue ? 1 : 0;
        }
        public bool GetBoolValue(int Value)
        {
            return Value == 1;
        }
    }
}
