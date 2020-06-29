using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concesionarias.Datos
{
    public partial class Articulo
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdArticulo">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Articulo GetArticulo(string IdArticulo)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdArticulo != "")
            {
                Filtro += "AND Id_Articulo = " + IdArticulo + " ";
            }
            return new Articulo(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdArticulo">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Articulo GetArticuloRelacional(string IdArticulo, string Codigo, string Linea, string Categoria, string Tercero)
        {
            string SqlString = "SELECT articulo.Id_Articulo, articulo.Id_Tercero, articulo.Id_Linea, articulo.Id_Categoria, articulo.Codigo_Articulo, articulo.Numero_Chasis_Articulo, articulo.Numero_Motor_Articulo, articulo.Certificado_Fabricacion_Articulo, articulo.Numero_Aduana_Articulo, articulo.Descripcion_Articulo, articulo.Anulado_Articulo, articulo.Stock_Minimo_Articulo, articulo.Stock_Articulo, articulo.Peso_Articulo, articulo.Dia_Compra_Articulo, articulo.Dia_Venta_Articulo, articulo.Precio_Costo_Articulo, articulo.Precio_Venta_Articulo, articulo.IVA_Articulo, articulo.Garantia_Articulo, articulo.Dominio_Articulo, articulo.ExTitular, articulo.Cuadro, articulo.Modelo, articulo.Color, articulo.Observaciones_Articulo, tercero.Id_Tercero, tercero.Id_Tercero_Tipo, tercero.Id_Tercero_IVA, tercero.Id_Localidad, tercero.Razon_Social_Tercero, tercero.Direccion_Tercero, tercero.Fecha_Nacimiento_Tercero, tercero.CUIT_Tercero, tercero.Telefonos_Tercero, tercero.DNI_Tercero, tercero.Fax_Tercero, tercero.Email_Tercero, tercero.Fecha_Alta_Tercero, tercero.Fecha_Baja_Tercero, tercero.Anulado_Tercero, tercero.Observaciones_Tercero, linea.Id_Linea, linea.Descripcion_Linea, categoria.Id_Categoria, categoria.Descripcion_Categoria FROM articulo INNER JOIN tercero ON (articulo.Id_Tercero = tercero.Id_Tercero) INNER JOIN linea ON (articulo.Id_Linea = linea.Id_Linea) INNER JOIN categoria ON (articulo.Id_Categoria = categoria.Id_Categoria)";

            string Filtro = " WHERE 0 < 1 ";
            if (IdArticulo != "")
            {
                Filtro += "AND articulo.Id_Articulo = " + IdArticulo + " ";
            }
            if (Codigo != "")
            {
                Filtro += "AND articulo.Codigo_Articulo LIKE '%" + Codigo + "%' ";
            }
            if (Linea != "")
            {
                Filtro += "AND articulo.Id_Linea = " + Linea + " ";
            }
            if (Categoria != "")
            {
                Filtro += "AND articulo.Id_Categoria = " + Categoria + " ";
            }
            if (Tercero != "")
            {
                Filtro += "AND articulo.Id_Tercero = " + Tercero + " ";
            }
            return new Articulo(Common.Peticion(SqlString + Filtro + ";"));
        }

        public static Articulo Los10MasVendidos(string FechaString)
        {
            DateTime Periodo = Convert.ToDateTime(FechaString);
            string SqlString = "SELECT RESULTADO.Id_Articulo, Count(RESULTADO.Cantidad_Factura_Detalle) AS CANTIDAD, RESULTADO.Descripcion_Articulo FROM (SELECT  factura_detalle.Id_Articulo, articulo.Descripcion_Articulo, factura_detalle.Cantidad_Factura_Detalle, factura.`Fecha_Factura` FROM factura_detalle INNER JOIN articulo ON (factura_detalle.Id_Articulo = articulo.Id_Articulo) INNER JOIN factura ON (factura_detalle.Id_Factura = factura.Id_Factura) WHERE factura.Fecha_Factura BETWEEN '" + Periodo.Year.ToString() + "-" + Periodo.Month.ToString() + "-1 00:00:00' AND '" + Periodo.Year.ToString() + "-" + (Periodo.Month + 1).ToString() + "-1 00:00:00') AS RESULTADO GROUP BY RESULTADO.Id_Articulo ORDER BY CANTIDAD DESC LIMIT 10";
            return new Articulo(Common.Peticion(SqlString + ";"));
        }

        public static System.Data.DataSet HistorialArticulo(string NumeroMotor,string NumeroChasis)
        {
            string Filtro = "WHERE 0 > 1 ";
            if (NumeroChasis != "")
            {
                Filtro += "OR articulo.numero_chasis_articulo = '" + NumeroChasis + "' ";
            }

            if (NumeroMotor != "")
            {
                Filtro += "OR articulo.numero_motor_articulo = '" + NumeroMotor + "'";
            }
            return Common.Peticion("SELECT factura_detalle.id_articulo, factura.fecha_factura, factura.numero_factura, factura.total_factura, factura_tipo.descripcion_factura_tipo, tercero.razon_social_tercero, factura_detalle.precio_unitario_factura_detalle, factura_detalle.cantidad_factura_detalle, COUNT(couta.id_couta) AS CantidadCuotas, articulo.iva_articulo, factura.clase_factura, factura.puesto_factura FROM factura_detalle INNER JOIN factura ON (factura_detalle.id_factura = factura.id_factura) INNER JOIN factura_tipo ON (factura.id_factura_tipo = factura_tipo.id_factura_tipo) INNER JOIN tercero ON (factura.id_tercero = tercero.id_tercero) INNER JOIN couta ON (couta.id_factura = factura.id_factura) INNER JOIN articulo ON (factura_detalle.id_articulo = articulo.id_articulo) " + Filtro + " GROUP BY factura_detalle.id_articulo, factura.fecha_factura, factura.numero_factura, factura.total_factura, factura_tipo.descripcion_factura_tipo, tercero.razon_social_tercero, factura_detalle.precio_unitario_factura_detalle, factura_detalle.cantidad_factura_detalle, articulo.iva_articulo, factura.clase_factura, factura.puesto_factura;");
        }
    }
    public partial class Caja
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdCaja">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Caja GetCaja(string IdCaja, string IdRecibo)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdCaja != "")
            {
                Filtro += "AND Id_Caja = " + IdCaja + " ";
            }
            if (IdRecibo != "")
            {
                Filtro += "AND Numero_Remito_Caja = " + IdRecibo + " ";
            }
            return new Caja(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdCaja">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Caja GetCajaRelacional(string IdCaja)
        {
            string SqlString = "SELECT caja.Id_Caja, caja.Id_Caja_Tipo, caja.Importe_Caja, caja.Fecha_Caja, caja.Numero_Remito_Caja, caja.Numero_Cuota_Caja, caja.Tag_Caja, caja_tipo.Id_Caja_Tipo, caja_tipo.Descripcion_Caja_Tipo FROM caja INNER JOIN caja_tipo ON (caja.Id_Caja_Tipo = caja_tipo.Id_Caja_Tipo)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdCaja != "")
            {
                Filtro += "AND caja.Id_Caja = " + IdCaja + " ";
            }
            return new Caja(Common.Peticion(SqlString + Filtro + " ORDER BY caja.Fecha_Caja;"));
        }
    }
    public partial class Caja_tipo
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdCaja_tipo">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Caja_tipo GetCaja_tipo(string IdCaja_tipo)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdCaja_tipo != "")
            {
                Filtro += "AND Id_Caja_tipo = " + IdCaja_tipo + " ";
            }
            return new Caja_tipo(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Categoria
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdCategoria">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Categoria GetCategoria(string IdCategoria)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdCategoria != "")
            {
                Filtro += "AND Id_Categoria = " + IdCategoria + " ";
            }
            return new Categoria(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Cheque_cartera
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdCheque_cartera">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Cheque_cartera GetCheque_cartera(string IdCheque_cartera, string IdFactura)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdCheque_cartera != "")
            {
                Filtro += "AND Id_Cheque_cartera = " + IdCheque_cartera + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND Numero_Recibo_Cheque_Cartera = " + IdFactura + " ";
            }
            return new Cheque_cartera(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdCheque_cartera">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Cheque_cartera GetCheque_carteraRelacional(string IdCheque_cartera, string NumeroRecibo)
        {
            string SqlString = "SELECT cheque_cartera.Id_Cheque_Cartera, cheque_cartera.Id_Localidad, cheque_cartera.Codigo_Cheque_Cartera, cheque_cartera.Numero_Recibo_Cheque_Cartera, cheque_cartera.Nombre_Cheque_Cartera, cheque_cartera.Fecha_Emicion_Cheque_Cartera, cheque_cartera.Fecha_Vencimiento_Cheque_Cartera, cheque_cartera.Nombre_Librador_Cheque_Cartera, cheque_cartera.Marca_Cheque_Cartera, cheque_cartera.Importe_Cheque_Cartera, cheque_cartera.Detalle_Cheque_Cartera, localidad.Id_Localidad, localidad.Id_Provincia, localidad.Nombre_Localidad, localidad.Codigo_Postal_Localidad FROM cheque_cartera INNER JOIN localidad ON (cheque_cartera.Id_Localidad = localidad.Id_Localidad)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdCheque_cartera != "")
            {
                Filtro += "AND cheque_cartera.Id_Cheque_cartera = " + IdCheque_cartera + " ";
            }
            if (NumeroRecibo != "")
            {
                Filtro += "AND cheque_cartera.Numero_Recibo_Cheque_Cartera = " + NumeroRecibo + " ";
            }
            return new Cheque_cartera(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Couta
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdCouta">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Couta GetCouta(string IdCouta, string IdFactura, string Pagado)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdCouta != "")
            {
                Filtro += "AND Id_Couta = " + IdCouta + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND Id_Factura = " + IdFactura + " ";
            }
            if (Pagado != "")
            {
                Filtro += "AND Pagado_Couta = " + Pagado + " ";
            }
            return new Couta(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdCouta">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Couta GetCoutaRelacional(string IdCouta, string VenciminetoDesde, string VenciminetoHasta, string Pagado, string InFactura, string IdTercero)
        {
            string SqlString = "SELECT couta.Id_Couta, couta.Id_Factura, couta.Numero_Couta_Couta, couta.Fecha_Vencimineto_Couta, couta.Fecha_Pago_Couta, couta.Importe_Couta, couta.Importe_Interes_Couta, couta.Asignacion_Cuota, couta.Pagado_Couta, couta.Observaciones_Couta, factura.Id_Factura, factura.Id_Tercero, factura.Id_Factura_Tipo, factura.Fecha_Factura, factura.Fecha_Vencimiento_Factura, factura.Clase_Factura, factura.Puesto_Factura, factura.Numero_Factura, factura.Neto_Factura, factura.IVA_105_Factura, factura.IVA_21_Factura, factura.IVA_27_Factura, factura.Percepcion_Factura, factura.Exentos_Factura, factura.Otros_Factura, factura.Total_Factura, factura.Retencion_Factura, factura.Anulado_Factura, factura.Facturado_Factura, factura.Pagado_Factura, factura.Observaciones_Factura FROM couta INNER JOIN factura ON (couta.Id_Factura = factura.Id_Factura) INNER JOIN tercero ON (factura.Id_Tercero = tercero.Id_Tercero)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdCouta != "")
            {
                Filtro += "AND couta.Id_Couta = " + IdCouta + " ";
            }
            if (VenciminetoDesde != "" && VenciminetoHasta != "")
            {
                Filtro += "AND couta.Fecha_Vencimineto_Couta BETWEEN '" + VenciminetoDesde + "' AND '" + VenciminetoHasta + "' ";
            }
            if (Pagado != "")
            {
                Filtro += "AND couta.Pagado_Couta = '" + Pagado + "' ";
            }
            if (InFactura != "")
            {
                Filtro += "AND couta.Id_Factura IN (" + InFactura + ") ";
            }
            if (IdTercero != "")
            {
                Filtro += "AND tercero.Id_Tercero = " + IdTercero + " ";
            }
            return new Couta(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Documento
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdDocumento">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Documento GetDocumento(string IdDocumento, string IdFactura)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdDocumento != "")
            {
                Filtro += "AND Id_Documento = " + IdDocumento + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND Id_Factura = " + IdFactura + " ";
            }
            return new Documento(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdDocumento">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Documento GetDocumentoRelacional(string IdDocumento, string RazonSocial)
        {
            string SqlString = "SELECT documento.Id_Documento, documento.Id_Factura, documento.Fecha_Entrega_Documento, documento.Dominio_Documento, documento.Observaciones_Documento, factura.Id_Factura, factura.Id_Tercero, factura.Id_Factura_Tipo, factura.Fecha_Factura, factura.Fecha_Vencimiento_Factura, factura.Clase_Factura, factura.Puesto_Factura, factura.Numero_Factura, factura.Neto_Factura, factura.IVA_105_Factura, factura.IVA_21_Factura, factura.IVA_27_Factura, factura.Percepcion_Factura, factura.Exentos_Factura, factura.Otros_Factura, factura.Total_Factura, factura.Retencion_Factura, factura.Anulado_Factura, factura.Facturado_Factura, factura.Observaciones_Factura FROM documento INNER JOIN factura ON (documento.Id_Factura = factura.Id_Factura) INNER JOIN tercero ON (factura.Id_Tercero = tercero.Id_Tercero)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdDocumento != "")
            {
                Filtro += "AND documento.Id_Documento = " + IdDocumento + " ";
            }
            if (RazonSocial != "")
            {
                Filtro += "AND tercero.Razon_Social_Tercero LIKE '%" + RazonSocial.Replace(" ", "%") + "%' ";
            }
            return new Documento(Common.Peticion(SqlString + Filtro + ";"));
        }
        /// <summary>
        /// Obtiene el ultimo numero de ID
        /// </summary>
        /// <returns>Ultimo numero de ID</returns>
        public static int UltimoID()
        {
            return Convert.ToInt32(Common.Peticion("SELECT MAX(documento.Id_Documento) FROM documento;").Tables[0].Rows[0][0]);
        }
    }
    public partial class Empresa
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdEmpresa">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Empresa GetEmpresa(string IdEmpresa)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdEmpresa != "")
            {
                Filtro += "AND Id_Empresa = " + IdEmpresa + " ";
            }
            return new Empresa(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdEmpresa">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Empresa GetEmpresaRelacional(string IdEmpresa)
        {
            string SqlString = "SELECT empresa.Id_Empresa, empresa.Id_Localidad, empresa.Id_Tercero_IVA, empresa.Razon_Social_Empresa, empresa.Titular_Empresa, empresa.CUIT_Empresa, empresa.Direccion_Empresa, empresa.Telefonos_Empresa, empresa.Fax_Empresa, empresa.Email_Empresa, empresa.Web_Empresa, empresa.Inicio_Actividades_Empresa, empresa.Ingresos_Brutos_Empresa, localidad.Id_Localidad, localidad.Id_Provincia, localidad.Nombre_Localidad, localidad.Codigo_Postal_Localidad, tercero_iva.Id_Tercero_IVA, tercero_iva.Descripcion_Tercero_IVA, tercero_iva.Abreviacion_Tercero_IVA, tercero_iva.Clase_Comprobante_Compra_Tercero_IVA, tercero_iva.Clase_Comprobante_Venta_Tercero_IVA FROM empresa INNER JOIN localidad ON (empresa.Id_Localidad = localidad.Id_Localidad) INNER JOIN tercero_iva ON (empresa.Id_Tercero_IVA = tercero_iva.Id_Tercero_IVA)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdEmpresa != "")
            {
                Filtro += "AND empresa.Id_Empresa = " + IdEmpresa + " ";
            }
            return new Empresa(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Factura
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura GetFactura(string IdFactura, string TipoFactura, string Clase, string Puesto, string Numero, string IdTercero, string FechaString)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura != "")
            {
                Filtro += "AND Id_Factura = " + IdFactura + " ";
            }

            if (TipoFactura != "")
            {
                Filtro += "AND Id_Factura_Tipo = " + TipoFactura + " ";
            }

            if (Clase != "")
            {
                Filtro += "AND Clase_Factura = '" + Clase + "' ";
            }

            if (Puesto != "")
            {
                Filtro += "AND Puesto_Factura = " + Puesto + " ";
            }

            if (Numero != "")
            {
                Filtro += "AND Numero_Factura = " + Numero + " ";
            }

            if (IdTercero != "")
            {
                Filtro += "AND Id_Tercero = " + IdTercero + " ";
            }

            if (FechaString != "")
            {
                DateTime Periodo = Convert.ToDateTime(FechaString);
                Filtro += "AND Fecha_Factura BETWEEN '" + Periodo.Year.ToString() + "-" + Periodo.Month.ToString() + "-1 00:00:00' AND '" + Periodo.Year.ToString() + "-" + (Periodo.Month + 1).ToString() + "-1 00:00:00'";
            }

            return new Factura(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdFactura">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura GetFacturaRelacional(string IdFactura, string IdFacturaTipo, string IdTercero, string TipoFacturaIn, string FechaString, string RazonSocial)
        {
            string SqlString = "SELECT factura.Id_Factura, factura.Id_Tercero, factura.Id_Factura_Tipo, factura.Fecha_Factura, factura.Fecha_Vencimiento_Factura, factura.Clase_Factura, factura.Puesto_Factura, factura.Numero_Factura, factura.Neto_Factura, factura.IVA_105_Factura, factura.IVA_21_Factura, factura.IVA_27_Factura, factura.Percepcion_Factura, factura.Exentos_Factura, factura.Otros_Factura, factura.Total_Factura, factura.Retencion_Factura, factura.Interes_Factura, factura.Anulado_Factura, factura.Facturado_Factura, factura.Pagado_Factura, factura.Observaciones_Factura, tercero.Id_Tercero, tercero.Id_Tercero_Tipo, tercero.Id_Tercero_IVA, tercero.Id_Localidad, tercero.Razon_Social_Tercero, tercero.Direccion_Tercero, tercero.Fecha_Nacimiento_Tercero, tercero.CUIT_Tercero, tercero.Telefonos_Tercero, tercero.DNI_Tercero, tercero.Fax_Tercero, tercero.Email_Tercero, tercero.Fecha_Alta_Tercero, tercero.Fecha_Baja_Tercero, tercero.Anulado_Tercero, tercero.Observaciones_Tercero, factura_tipo.Id_Factura_Tipo, factura_tipo.Descripcion_Factura_Tipo, factura_tipo.Abreviacion_Factura_Tipo FROM factura INNER JOIN tercero ON (factura.Id_Tercero = tercero.Id_Tercero) INNER JOIN factura_tipo ON (factura.Id_Factura_Tipo = factura_tipo.Id_Factura_Tipo)";

            string Filtro = " WHERE 0 < 1 ";

            if (IdFactura != "")
            {
                Filtro += "AND factura.Id_Factura = " + IdFactura + " ";
            }

            if (IdFacturaTipo != "")
            {
                Filtro += "AND factura.Id_Factura_Tipo = " + IdFacturaTipo + " ";
            }

            if (TipoFacturaIn != "")
            {
                Filtro += "AND factura.Id_Factura_Tipo IN (" + TipoFacturaIn + ") ";
            }

            if (IdTercero != "")
            {
                Filtro += "AND factura.Id_Tercero = " + IdTercero + " ";
            }

            if (FechaString != "")
            {
                DateTime Periodo = Convert.ToDateTime(FechaString);
                Filtro += "AND factura.Fecha_Factura BETWEEN '" + Periodo.Year.ToString() + "-" + Periodo.Month.ToString() + "-1 00:00:00' AND '" + Periodo.Year.ToString() + "-" + (Periodo.Month + 1).ToString() + "-1 00:00:00'";
            }

            if (RazonSocial != "")
            {
                Filtro += "AND tercero.Razon_Social_Tercero LIKE '%" + RazonSocial.Replace(" ", "%") + "%' ";
            }
            return new Factura(Common.Peticion(SqlString + Filtro + ";"));
        }

        public static bool AddFactura_detalle(Factura ObjFactura, Factura_detalle ObjFactura_detalle, Couta ObjCoutas, Factura_garante ObjFactura_garante)
        {
            bool HuboError = false;
            Concesionarias.Datos.Common.AbrirConexion();

            if (!AddSinTransaccion(ObjFactura))
            {
                HuboError = true;
            }

            if (ObjFactura.Id_Factura_Tipo == 2)
            {
                //resta, porque se vendio o remitaron algunos articulos
                foreach (Factura_detalle itemFactura_detalle in ObjFactura_detalle.ListaFactura_detalle)
                {
                    Articulo A = Articulo.GetArticulo(itemFactura_detalle.Id_Articulo.ToString());
                    A.ListaArticulo[0].Stock_Articulo = A.ListaArticulo[0].Stock_Articulo - itemFactura_detalle.Cantidad_Factura_Detalle;
                    A.ListaArticulo[0].Dia_Venta_Articulo = DateTime.Now;
                    if (!Articulo.SetSinTransaccion(A.ListaArticulo[0]))
                    {
                        HuboError = true;
                    }
                }
            }

            if (ObjFactura.Id_Factura_Tipo == 1)
            {
                //suma, porque se compraron nuevos articulos
                foreach (Factura_detalle itemFactura_detalle in ObjFactura_detalle.ListaFactura_detalle)
                {
                    Articulo A = Articulo.GetArticulo(itemFactura_detalle.Id_Articulo.ToString());
                    A.ListaArticulo[0].Stock_Articulo = A.ListaArticulo[0].Stock_Articulo + itemFactura_detalle.Cantidad_Factura_Detalle;
                    A.ListaArticulo[0].Dia_Compra_Articulo = DateTime.Now;
                    A.ListaArticulo[0].Precio_Costo_Articulo = itemFactura_detalle.Precio_Unitario_Factura_Detalle;
                    if (!Articulo.SetSinTransaccion(A.ListaArticulo[0]))
                    {
                        HuboError = true;
                    }
                }
            }

            int UltimoId = Convert.ToInt32(Common.Peticion("SELECT MAX(factura.Id_Factura) FROM factura;").Tables[0].Rows[0][0]);

            foreach (Factura_detalle ItemFactura_detalle in ObjFactura_detalle.ListaFactura_detalle)
            {
                ItemFactura_detalle.Id_Factura = UltimoId;
                if (!Factura_detalle.AddSinTransaccion(ItemFactura_detalle))
                {
                    HuboError = true;
                }
            }

            foreach (Datos.Factura_garante itemFactura_garante in ObjFactura_garante.ListaFactura_garante)
            {
                itemFactura_garante.Id_Factura = UltimoId;
                if (!Factura_garante.AddSinTransaccion(itemFactura_garante))
                {
                    HuboError = true;
                }
            }

            foreach (Datos.Couta itemCouta in ObjCoutas.ListaCouta)
            {
                itemCouta.Id_Factura = UltimoId;

                if (!Couta.AddSinTransaccion(itemCouta))
                {
                    HuboError = true;
                }
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SetFactura_detalle(Factura ObjFactura, Factura_detalle ObjFactura_detalle, Couta ObjCoutas, Factura_garante ObjFactura_garante)
        {
            bool HuboError = false;

            Concesionarias.Datos.Common.AbrirConexion();
            //seteo el nuevo encabesado del remito
            if (!SetSinTransaccion(ObjFactura))
            {
                HuboError = true;
            }

            //primero borro todos los detalles que existen
            Factura_detalle DetalleAnterior = Factura_detalle.GetFactura_detalle("", ObjFactura.Id_Factura.ToString());
            foreach (Factura_detalle ItemFactura_detalle in DetalleAnterior.ListaFactura_detalle)
            {
                if (!Factura_detalle.DeleteSinTransaccion(ItemFactura_detalle.Id_Factura_Detalle.ToString()))
                {
                    HuboError = true;
                }
            }

            //aca cargo los nuevos detalles
            foreach (Factura_detalle ItemFactura_detalle in ObjFactura_detalle.ListaFactura_detalle)
            {
                ItemFactura_detalle.Id_Factura = ObjFactura.Id_Factura;
                if (!Factura_detalle.AddSinTransaccion(ItemFactura_detalle))
                {
                    HuboError = true;
                }
            }

            //Borro los garantes anteriores
            Factura_garante Factura_garanteAnterior = Factura_garante.GetFactura_garante("", ObjFactura.Id_Factura.ToString());
            foreach (Factura_garante ItemFactura_garante in Factura_garanteAnterior.ListaFactura_garante)
            {
                if (!Factura_garante.DeleteSinTransaccion(ItemFactura_garante.Id_Factura_Garante.ToString()))
                {
                    HuboError = true;
                }
            }

            //agrego lo nuevos garantes
            foreach (Datos.Factura_garante itemFactura_garante in ObjFactura_garante.ListaFactura_garante)
            {
                itemFactura_garante.Id_Factura = ObjFactura.Id_Factura;
                if (!Factura_garante.AddSinTransaccion(itemFactura_garante))
                {
                    HuboError = true;
                }
            }

            //borro las cuotas viejas
            Couta CoutaAnterior = Couta.GetCouta("", ObjFactura.Id_Factura.ToString(), "");
            foreach (Couta ItemCouta in CoutaAnterior.ListaCouta)
            {
                if (!Couta.DeleteSinTransaccion(ItemCouta.Id_Couta.ToString()))
                {
                    HuboError = true;
                }
            }

            //agrego la nuevas cuotas
            foreach (Datos.Couta itemCouta in ObjCoutas.ListaCouta)
            {
                itemCouta.Id_Factura = ObjFactura.Id_Factura;

                if (!Couta.AddSinTransaccion(itemCouta))
                {
                    HuboError = true;
                }
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteFactura_detalle(string IdFactura)
        {
            bool HuboError = false;

            Concesionarias.Datos.Common.AbrirConexion();
            Factura FacturaOriginal = Factura.GetFactura(IdFactura, "", "", "", "", "", "");

            //primero acomodo los valores del stock para esa factura
            //depues borro todos los detalles de la factura si tiene
            Factura_detalle DetalleAnterior = Factura_detalle.GetFactura_detalle("", IdFactura);

            if (FacturaOriginal.ListaFactura[0].Id_Factura_Tipo == 2)
            {
                //sumo, porque se vendio o remitaron algunos articulos se tiene que devolver
                foreach (Factura_detalle itemFactura_detalle in DetalleAnterior.ListaFactura_detalle)
                {
                    Articulo A = Articulo.GetArticulo(itemFactura_detalle.Id_Articulo.ToString());
                    A.ListaArticulo[0].Stock_Articulo = A.ListaArticulo[0].Stock_Articulo + itemFactura_detalle.Cantidad_Factura_Detalle;
                    if (!Articulo.SetSinTransaccion(A.ListaArticulo[0]))
                    {
                        HuboError = true;
                    }
                }
            }

            if (FacturaOriginal.ListaFactura[0].Id_Factura_Tipo == 1)
            {
                //resto, porque se compraron nuevos articulos algunas articulos,cuando se elimina simula no haber comprado nunca
                foreach (Factura_detalle itemFactura_detalle in DetalleAnterior.ListaFactura_detalle)
                {
                    Articulo A = Articulo.GetArticulo(itemFactura_detalle.Id_Articulo.ToString());
                    A.ListaArticulo[0].Stock_Articulo = A.ListaArticulo[0].Stock_Articulo - itemFactura_detalle.Cantidad_Factura_Detalle;
                    if (!Articulo.SetSinTransaccion(A.ListaArticulo[0]))
                    {
                        HuboError = true;
                    }
                }
            }

            foreach (Factura_detalle ItemFactura_detalle in DetalleAnterior.ListaFactura_detalle)
            {
                if (!Factura_detalle.DeleteSinTransaccion(ItemFactura_detalle.Id_Factura_Detalle.ToString()))
                {
                    HuboError = true;
                }
            }

            //Aca borro la entrega de la documentacion, si la tiene
            Documento Doc = Documento.GetDocumento("", IdFactura);
            foreach (Documento itemDocumento in Doc.ListaDocumento)
            {
                if (!Documento.DeleteSinTransaccion(itemDocumento.Id_Documento.ToString()))
                {
                    HuboError = true;
                }
            }

            //Aca borro los garantes , si los tiene
            Factura_garante FG = Factura_garante.GetFactura_garante("", IdFactura);
            foreach (Factura_garante itemFactura_garante in FG.ListaFactura_garante)
            {
                if (!Factura_garante.DeleteSinTransaccion(itemFactura_garante.Id_Factura_Garante.ToString()))
                {
                    HuboError = true;
                }
            }

            //Aca borro las cuotas
            Couta CoutaAnterior = Couta.GetCouta("", IdFactura, "");
            foreach (Couta ItemCouta in CoutaAnterior.ListaCouta)
            {
                //BUSCAS LAS CUOTAS QUE TIENEN RECIBOS Y BORRA LOS RECIBO
                Factura_recibo_asignaciones FRA = Factura_recibo_asignaciones.GetFactura_recibo_asignaciones("", "", ItemCouta.Id_Couta.ToString());
                foreach (Factura_recibo_asignaciones itemFactura_recibo_asignaciones in FRA.ListaFactura_recibo_asignaciones)
                {
                    DeleteRecibo_OrdenPagoSinTransaccion(itemFactura_recibo_asignaciones.Id_Factura.ToString(), ref HuboError);
                }

                if (!Couta.DeleteSinTransaccion(ItemCouta.Id_Couta.ToString()))
                {
                    HuboError = true;
                }
            }

            //aca borro la factura en si..
            if (!Factura.DeleteSinTransaccion(IdFactura))
            {
                HuboError = true;
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AnularFactura_detalle(string IdFactura)
        {
            bool HuboError = false;

            Concesionarias.Datos.Common.AbrirConexion();
            Factura FacturaOriginal = Factura.GetFactura(IdFactura, "", "", "", "", "", "");

            //primero acomodo los valores del stock para esa factura
            //depues borro todos los detalles de la factura si tiene
            Factura_detalle DetalleAnterior = Factura_detalle.GetFactura_detalle("", IdFactura);

            if (FacturaOriginal.ListaFactura[0].Id_Factura_Tipo == 2)
            {
                //sumo, porque se vendio o remitaron algunos articulos se tiene que devolver
                foreach (Factura_detalle itemFactura_detalle in DetalleAnterior.ListaFactura_detalle)
                {
                    Articulo A = Articulo.GetArticulo(itemFactura_detalle.Id_Articulo.ToString());
                    A.ListaArticulo[0].Stock_Articulo = A.ListaArticulo[0].Stock_Articulo + itemFactura_detalle.Cantidad_Factura_Detalle;
                    if (!Articulo.SetSinTransaccion(A.ListaArticulo[0]))
                    {
                        HuboError = true;
                    }
                }
            }

            if (FacturaOriginal.ListaFactura[0].Id_Factura_Tipo == 1)
            {
                //resto, porque se compraron nuevos articulos algunas articulos,cuando se elimina simula no haber comprado nunca
                foreach (Factura_detalle itemFactura_detalle in DetalleAnterior.ListaFactura_detalle)
                {
                    Articulo A = Articulo.GetArticulo(itemFactura_detalle.Id_Articulo.ToString());
                    A.ListaArticulo[0].Stock_Articulo = A.ListaArticulo[0].Stock_Articulo - itemFactura_detalle.Cantidad_Factura_Detalle;
                    if (!Articulo.SetSinTransaccion(A.ListaArticulo[0]))
                    {
                        HuboError = true;
                    }
                }
            }

            foreach (Factura_detalle ItemFactura_detalle in DetalleAnterior.ListaFactura_detalle)
            {
                if (!Factura_detalle.DeleteSinTransaccion(ItemFactura_detalle.Id_Factura_Detalle.ToString()))
                {
                    HuboError = true;
                }
            }

            //Aca borro la entrega de la documentacion, si la tiene
            Documento Doc = Documento.GetDocumento("", IdFactura);
            foreach (Documento itemDocumento in Doc.ListaDocumento)
            {
                if (!Documento.DeleteSinTransaccion(itemDocumento.Id_Documento.ToString()))
                {
                    HuboError = true;
                }
            }

            //Aca borro los garantes , si los tiene
            Factura_garante FG = Factura_garante.GetFactura_garante("", IdFactura);
            foreach (Factura_garante itemFactura_garante in FG.ListaFactura_garante)
            {
                if (!Factura_garante.DeleteSinTransaccion(itemFactura_garante.Id_Factura_Garante.ToString()))
                {
                    HuboError = true;
                }
            }

            //Aca borro las cuotas
            Couta CoutaAnterior = Couta.GetCouta("", IdFactura, "");
            foreach (Couta ItemCouta in CoutaAnterior.ListaCouta)
            {
                //BUSCAS LAS CUOTAS QUE TIENEN RECIBOS Y BORRA LOS RECIBO
                Factura_recibo_asignaciones FRA = Factura_recibo_asignaciones.GetFactura_recibo_asignaciones("", "", ItemCouta.Id_Couta.ToString());
                foreach (Factura_recibo_asignaciones itemFactura_recibo_asignaciones in FRA.ListaFactura_recibo_asignaciones)
                {
                    DeleteRecibo_OrdenPagoSinTransaccion(itemFactura_recibo_asignaciones.Id_Factura.ToString(), ref HuboError);
                }

                if (!Couta.DeleteSinTransaccion(ItemCouta.Id_Couta.ToString()))
                {
                    HuboError = true;
                }
            }

            //aca MARCO LA FACTURA COMO NULA la factura en si..
            FacturaOriginal.ListaFactura[0].Anulado_Factura = true;
            if (!Factura.SetSinTransaccion(FacturaOriginal.ListaFactura[0]))
            {
                HuboError = true;
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void DeleteRecibo_OrdenPagoSinTransaccion(string IdFactura, ref bool HuboError)
        {
            Factura FacturaOriginal = Factura.GetFactura(IdFactura, "", "", "", "", "", "").ListaFactura[0];

            //buscar las facturas asisnadas y sumar el importe en pendiente a todas las facturas
            Factura_recibo_asignaciones FRA = Factura_recibo_asignaciones.GetFactura_recibo_asignaciones("", IdFactura, "");

            foreach (Factura_recibo_asignaciones itemFactura_recibo_asignaciones in FRA.ListaFactura_recibo_asignaciones)
            {
                Couta C = Couta.GetCouta(itemFactura_recibo_asignaciones.Factura_Asignada_Factura_Recibo_Asignaciones.ToString(), "", "").ListaCouta[0];
                C.Pagado_Couta = false;
                C.Asignacion_Cuota -= FacturaOriginal.Total_Factura;
                if (C.Asignacion_Cuota < 0)
                {
                    C.Asignacion_Cuota = 0;
                }
                C.Importe_Interes_Couta = 0;
                C.Observaciones_Couta += " [CUOTA CANCELADA POR EL BORRADO DEL DEL RECIBO " + FacturaOriginal.Clase_Factura + " " + FacturaOriginal.Puesto_Factura.ToString("0000") + "-" + FacturaOriginal.Numero_Factura.ToString("00000000") + "]";
                if (!Couta.SetSinTransaccion(C))
                {
                    HuboError = true;
                }
                if (!Factura_recibo_asignaciones.DeleteSinTransaccion(itemFactura_recibo_asignaciones.Id_Factura_Recibo_Asignaciones.ToString()))
                {
                    HuboError = true;
                }
            }

            //busco en los detalles, y segun el tipo de recibo, devolver todo como estaba
            //eliminar lo de caja, tarjeta, banco, y en checarte ponerlo como no entregado

            Factura_recibo_detalle FRD = Factura_recibo_detalle.GetFactura_recibo_detalle("", IdFactura);

            foreach (Factura_recibo_detalle itemFactura_recibo_detalle in FRD.ListaFactura_recibo_detalle)
            {
                if (!Factura_recibo_detalle.DeleteSinTransaccion(itemFactura_recibo_detalle.Id_Factura_Recibo_Detalle.ToString()))
                {
                    HuboError = true;
                }
            }

            Caja Efectivo = Caja.GetCaja("", IdFactura);

            foreach (Caja itemCaja in Efectivo.ListaCaja)
            {
                if (!Caja.DeleteSinTransaccion(itemCaja.Id_Caja.ToString()))
                {
                    HuboError = true;
                }
            }

            Cheque_cartera CC = Cheque_cartera.GetCheque_cartera("", IdFactura);
            foreach (Cheque_cartera itemCheque_cartera in CC.ListaCheque_cartera)
            {
                if (!Cheque_cartera.DeleteSinTransaccion(itemCheque_cartera.Id_Cheque_Cartera.ToString()))
                {
                    HuboError = true;
                }
            }

            //aca borro la orden de pago
            if (!DeleteSinTransaccion(IdFactura))
            {
                HuboError = true;
            }
        }

        public static bool DeleteRecibo_OrdenPago(string IdFactura)
        {
            bool HuboError = false;

            Concesionarias.Datos.Common.AbrirConexion();

            DeleteRecibo_OrdenPagoSinTransaccion(IdFactura, ref HuboError);

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AddRecibo_OrdenPago(Factura ObjFactura, Couta ObjCuotas, Cheque_cartera ObjCheque_Cartera, Caja ObjCaja)
        {
            bool HuboError = false;
            Concesionarias.Datos.Common.AbrirConexion();

            if (!AddSinTransaccion(ObjFactura))
            {
                HuboError = true;
            }

            int UltimoId = Convert.ToInt32(Common.Peticion("SELECT MAX(factura.Id_Factura) FROM factura;").Tables[0].Rows[0][0]);

            foreach (Couta itemCouta in ObjCuotas.ListaCouta)
            {
                Factura_recibo_asignaciones FRA = new Factura_recibo_asignaciones();
                FRA.Det1_Factura_Recibo_Asignaciones = "";
                FRA.Factura_Asignada_Factura_Recibo_Asignaciones = itemCouta.Id_Couta;
                FRA.Id_Factura = UltimoId;
                FRA.Importe_Descuento_Factura_Recibo_Asignaciones = 0;
                FRA.Importe_Factura_Recibo_Asignaciones = itemCouta.Importe_Couta + itemCouta.Importe_Interes_Couta;
                FRA.Impresa_Factura_Recibo_Asignaciones = false;

                if (!Couta.SetSinTransaccion(itemCouta))
                {
                    HuboError = true;
                }

                if (!Factura_recibo_asignaciones.AddSinTransaccion(FRA))
                {
                    HuboError = true;
                }
            }

            Factura_recibo_detalle FRD = new Factura_recibo_detalle();
            FRD.ListaFactura_recibo_detalle = new List<Factura_recibo_detalle>();

            foreach (Caja itemCaja in ObjCaja.ListaCaja)
            {
                Factura_recibo_detalle TEMP = new Factura_recibo_detalle();
                TEMP.Id_Factura = UltimoId;
                TEMP.Id_Factura_Recibo_Tipo = 1;
                TEMP.Importe_Descuento_Factura_Recibo_Detalle = 0;
                TEMP.Importe_Factura_Recibo_Detalle = itemCaja.Importe_Caja;

                FRD.ListaFactura_recibo_detalle.Add(TEMP);

                itemCaja.Numero_Remito_Caja = UltimoId;
                if (!Caja.AddSinTransaccion(itemCaja))
                {
                    HuboError = true;
                }
            }

            foreach (Cheque_cartera itemCheque_cartera in ObjCheque_Cartera.ListaCheque_cartera)
            {
                Factura_recibo_detalle TEMP = new Factura_recibo_detalle();
                TEMP.Id_Factura = UltimoId;
                TEMP.Id_Factura_Recibo_Tipo = 2;
                TEMP.Importe_Descuento_Factura_Recibo_Detalle = 0;
                TEMP.Importe_Factura_Recibo_Detalle = itemCheque_cartera.Importe_Cheque_Cartera;

                FRD.ListaFactura_recibo_detalle.Add(TEMP);

                itemCheque_cartera.Numero_Recibo_Cheque_Cartera = UltimoId;
                if (!Cheque_cartera.AddSinTransaccion(itemCheque_cartera))
                {
                    HuboError = true;
                }
            }

            foreach (Factura_recibo_detalle itemFactura_recibo_detalle in FRD.ListaFactura_recibo_detalle)
            {
                if (!Factura_recibo_detalle.AddSinTransaccion(itemFactura_recibo_detalle))
                {
                    HuboError = true;
                }
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public partial class Factura_detalle
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura_detalle">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_detalle GetFactura_detalle(string IdFactura_detalle, string IdFactura)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura_detalle != "")
            {
                Filtro += "AND Id_Factura_detalle = " + IdFactura_detalle + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND Id_Factura = " + IdFactura + " ";
            }
            return new Factura_detalle(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdFactura_detalle">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_detalle GetFactura_detalleRelacional(string IdFactura_detalle, string IdFactura)
        {
            string SqlString = "SELECT factura_detalle.Id_Factura_Detalle, factura_detalle.Id_Factura, factura_detalle.Id_Articulo, factura_detalle.Cantidad_Factura_Detalle, factura_detalle.Precio_Unitario_Factura_Detalle, factura_detalle.Bonifica_Factura_Detalle, factura.Id_Factura, factura.Id_Tercero, factura.Id_Factura_Tipo, factura.Fecha_Factura, factura.Fecha_Vencimiento_Factura, factura.Clase_Factura, factura.Puesto_Factura, factura.Numero_Factura, factura.Neto_Factura, factura.IVA_105_Factura, factura.IVA_21_Factura, factura.IVA_27_Factura, factura.Percepcion_Factura, factura.Exentos_Factura, factura.Otros_Factura, factura.Total_Factura, factura.Retencion_Factura, factura.Anulado_Factura, factura.Facturado_Factura, factura.Pagado_Factura, factura.Observaciones_Factura, articulo.Id_Articulo, articulo.Id_Tercero, articulo.Id_Linea, articulo.Id_Categoria, articulo.Codigo_Articulo, articulo.Numero_Chasis_Articulo, articulo.Numero_Motor_Articulo, articulo.Certificado_Fabricacion_Articulo, articulo.Numero_Aduana_Articulo, articulo.Descripcion_Articulo, articulo.Anulado_Articulo, articulo.Stock_Minimo_Articulo, articulo.Stock_Articulo, articulo.Peso_Articulo, articulo.Dia_Compra_Articulo, articulo.Dia_Venta_Articulo, articulo.Precio_Costo_Articulo, articulo.Precio_Venta_Articulo, articulo.IVA_Articulo, articulo.Garantia_Articulo, articulo.Dominio_Articulo, articulo.ExTitular, articulo.Cuadro, articulo.Modelo, articulo.Color, articulo.Observaciones_Articulo FROM factura_detalle INNER JOIN factura ON (factura_detalle.Id_Factura = factura.Id_Factura) INNER JOIN articulo ON (factura_detalle.Id_Articulo = articulo.Id_Articulo)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdFactura_detalle != "")
            {
                Filtro += "AND factura_detalle.Id_Factura_detalle = " + IdFactura_detalle + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND factura_detalle.Id_Factura = " + IdFactura + " ";
            }
            return new Factura_detalle(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Factura_garante
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura_garante">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_garante GetFactura_garante(string IdFactura_garante, string IdFactura)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura_garante != "")
            {
                Filtro += "AND Id_Factura_garante = " + IdFactura_garante + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND Id_Factura = " + IdFactura + " ";
            }
            return new Factura_garante(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdFactura_garante">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_garante GetFactura_garanteRelacional(string IdFactura_garante, string IdFactura)
        {
            string SqlString = "SELECT factura_garante.Id_Factura_Garante, factura_garante.Id_Factura, factura_garante.Id_Tercero, factura.Id_Factura, factura.Id_Tercero, factura.Id_Factura_Tipo, factura.Fecha_Factura, factura.Fecha_Vencimiento_Factura, factura.Clase_Factura, factura.Puesto_Factura, factura.Numero_Factura, factura.Neto_Factura, factura.IVA_105_Factura, factura.IVA_21_Factura, factura.IVA_27_Factura, factura.Percepcion_Factura, factura.Exentos_Factura, factura.Otros_Factura, factura.Total_Factura, factura.Retencion_Factura, factura.Anulado_Factura, factura.Facturado_Factura, factura.Pagado_Factura, factura.Observaciones_Factura, tercero.Id_Tercero, tercero.Id_Tercero_Tipo, tercero.Id_Tercero_IVA, tercero.Id_Localidad, tercero.Razon_Social_Tercero, tercero.Direccion_Tercero, tercero.Fecha_Nacimiento_Tercero, tercero.CUIT_Tercero, tercero.Telefonos_Tercero, tercero.DNI_Tercero, tercero.Fax_Tercero, tercero.Email_Tercero, tercero.Fecha_Alta_Tercero, tercero.Fecha_Baja_Tercero, tercero.Anulado_Tercero, tercero.Observaciones_Tercero FROM factura_garante INNER JOIN tercero ON (factura_garante.Id_Tercero = tercero.Id_Tercero) INNER JOIN factura ON (factura_garante.Id_Factura = factura.Id_Factura)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdFactura_garante != "")
            {
                Filtro += "AND factura_garante.Id_Factura_garante = " + IdFactura_garante + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND factura_garante.Id_Factura = " + IdFactura + " ";
            }
            return new Factura_garante(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Factura_recibo_asignaciones
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura_recibo_asignaciones">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_recibo_asignaciones GetFactura_recibo_asignaciones(string IdFactura_recibo_asignaciones, string IdFactura, string FacturaAsignada)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura_recibo_asignaciones != "")
            {
                Filtro += "AND Id_Factura_recibo_asignaciones = " + IdFactura_recibo_asignaciones + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND Id_Factura = " + IdFactura + " ";
            }
            if (FacturaAsignada != "")
            {
                Filtro += "AND Factura_Asignada_Factura_Recibo_Asignaciones = " + FacturaAsignada + " ";
            }
            return new Factura_recibo_asignaciones(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdFactura_recibo_asignaciones">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_recibo_asignaciones GetFactura_recibo_asignacionesRelacional(string IdFactura_recibo_asignaciones, string IdFactura)
        {
            string SqlString = "SELECT factura_recibo_asignaciones.Id_Factura_Recibo_Asignaciones, factura_recibo_asignaciones.Id_Factura, factura_recibo_asignaciones.Factura_Asignada_Factura_Recibo_Asignaciones, factura_recibo_asignaciones.Impresa_Factura_Recibo_Asignaciones, factura_recibo_asignaciones.Det1_Factura_Recibo_Asignaciones, factura_recibo_asignaciones.Importe_Factura_Recibo_Asignaciones, factura_recibo_asignaciones.Importe_Descuento_Factura_Recibo_Asignaciones, factura.Id_Factura, factura.Id_Tercero, factura.Id_Factura_Tipo, factura.Fecha_Factura, factura.Fecha_Vencimiento_Factura, factura.Clase_Factura, factura.Puesto_Factura, factura.Numero_Factura, factura.Neto_Factura, factura.IVA_105_Factura, factura.IVA_21_Factura, factura.IVA_27_Factura, factura.Percepcion_Factura, factura.Exentos_Factura, factura.Otros_Factura, factura.Total_Factura, factura.Retencion_Factura, factura.Anulado_Factura, factura.Facturado_Factura, factura.Pagado_Factura, factura.Observaciones_Factura FROM factura_recibo_asignaciones INNER JOIN factura ON (factura_recibo_asignaciones.Id_Factura = factura.Id_Factura)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdFactura_recibo_asignaciones != "")
            {
                Filtro += "AND factura_recibo_asignaciones.Id_Factura_recibo_asignaciones = " + IdFactura_recibo_asignaciones + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND factura_recibo_asignaciones.Id_Factura = " + IdFactura + " ";
            }
            return new Factura_recibo_asignaciones(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Factura_recibo_detalle
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura_recibo_detalle">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_recibo_detalle GetFactura_recibo_detalle(string IdFactura_recibo_detalle, string IdFactura)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura_recibo_detalle != "")
            {
                Filtro += "AND Id_Factura_recibo_detalle = " + IdFactura_recibo_detalle + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND Id_Factura = " + IdFactura + " ";
            }
            return new Factura_recibo_detalle(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdFactura_recibo_detalle">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_recibo_detalle GetFactura_recibo_detalleRelacional(string IdFactura_recibo_detalle)
        {
            string SqlString = "SELECT factura_recibo_detalle.Id_Factura_Recibo_Detalle, factura_recibo_detalle.Id_Factura, factura_recibo_detalle.Id_Factura_Recibo_Tipo, factura_recibo_detalle.Importe_Factura_Recibo_Detalle, factura_recibo_detalle.Importe_Descuento_Factura_Recibo_Detalle, factura.Id_Factura, factura.Id_Tercero, factura.Id_Factura_Tipo, factura.Fecha_Factura, factura.Fecha_Vencimiento_Factura, factura.Clase_Factura, factura.Puesto_Factura, factura.Numero_Factura, factura.Neto_Factura, factura.IVA_105_Factura, factura.IVA_21_Factura, factura.IVA_27_Factura, factura.Percepcion_Factura, factura.Exentos_Factura, factura.Otros_Factura, factura.Total_Factura, factura.Retencion_Factura, factura.Anulado_Factura, factura.Facturado_Factura, factura.Pagado_Factura, factura.Observaciones_Factura, factura_recibo_tipo.Id_Factura_Recibo_Tipo, factura_recibo_tipo.Descripcion_Factura_Recibo_Tipo FROM factura_recibo_detalle INNER JOIN factura_recibo_tipo ON (factura_recibo_detalle.Id_Factura_Recibo_Tipo = factura_recibo_tipo.Id_Factura_Recibo_Tipo) INNER JOIN factura ON (factura_recibo_detalle.Id_Factura = factura.Id_Factura)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdFactura_recibo_detalle != "")
            {
                Filtro += "AND factura_recibo_detalle.Id_Factura_recibo_detalle = " + IdFactura_recibo_detalle + " ";
            }
            return new Factura_recibo_detalle(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Factura_recibo_tipo
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura_recibo_tipo">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_recibo_tipo GetFactura_recibo_tipo(string IdFactura_recibo_tipo)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura_recibo_tipo != "")
            {
                Filtro += "AND Id_Factura_recibo_tipo = " + IdFactura_recibo_tipo + " ";
            }
            return new Factura_recibo_tipo(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Factura_tipo
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura_tipo">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_tipo GetFactura_tipo(string IdFactura_tipo)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura_tipo != "")
            {
                Filtro += "AND Id_Factura_tipo = " + IdFactura_tipo + " ";
            }
            return new Factura_tipo(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Historial_sql
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdHistorial_sql">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Historial_sql GetHistorial_sql(string IdHistorial_sql)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdHistorial_sql != "")
            {
                Filtro += "AND Id_Historial_sql = " + IdHistorial_sql + " ";
            }
            return new Historial_sql(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Linea
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdLinea">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Linea GetLinea(string IdLinea)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdLinea != "")
            {
                Filtro += "AND Id_Linea = " + IdLinea + " ";
            }
            return new Linea(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Localidad
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdLocalidad">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Localidad GetLocalidad(string IdLocalidad)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdLocalidad != "")
            {
                Filtro += "AND Id_Localidad = " + IdLocalidad + " ";
            }
            return new Localidad(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdLocalidad">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Localidad GetLocalidadRelacional(string IdLocalidad)
        {
            string SqlString = "SELECT localidad.Id_Localidad, localidad.Id_Provincia, localidad.Nombre_Localidad, localidad.Codigo_Postal_Localidad, provincia.Id_Provincia, provincia.Id_Pais, provincia.Nombre_Provincia FROM localidad INNER JOIN provincia ON (localidad.Id_Provincia = provincia.Id_Provincia)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdLocalidad != "")
            {
                Filtro += "AND localidad.Id_Localidad = " + IdLocalidad + " ";
            }
            return new Localidad(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Pais
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdPais">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Pais GetPais(string IdPais)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdPais != "")
            {
                Filtro += "AND Id_Pais = " + IdPais + " ";
            }
            return new Pais(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Provincia
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdProvincia">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Provincia GetProvincia(string IdProvincia)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdProvincia != "")
            {
                Filtro += "AND Id_Provincia = " + IdProvincia + " ";
            }
            return new Provincia(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdProvincia">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Provincia GetProvinciaRelacional(string IdProvincia)
        {
            string SqlString = "SELECT provincia.Id_Provincia, provincia.Id_Pais, provincia.Nombre_Provincia, pais.Id_Pais, pais.Nombre_Pais FROM provincia INNER JOIN pais ON (provincia.Id_Pais = pais.Id_Pais)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdProvincia != "")
            {
                Filtro += "AND provincia.Id_Provincia = " + IdProvincia + " ";
            }
            return new Provincia(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Series
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdSeries">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Series GetSeries(string IdSeries)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdSeries != "")
            {
                Filtro += "AND Id_Series = " + IdSeries + " ";
            }
            return new Series(Common.Peticion(GetSelect(Filtro)));
        }

        public static int UltimoNumeroComprobante(string TipoFactura)
        {
            //buscar el valor y bloquear el registro
            Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
            return S.ListaSeries[0].Numero;
        }

        public static int Bloquear(string TipoFactura)
        {
            //buscar el valor y bloquear el registro
            Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
            if (S.ListaSeries[0].Bloqueado)
            {
                throw new Exception("Este tipo de comprobante esta siendo usado.");
            }
            else
            {
                S.ListaSeries[0].Bloqueado = true;
                S.ListaSeries[0].Comprobante = "'" + S.ListaSeries[0].Comprobante + "'";
                Series.Set(S.ListaSeries[0]);
                return S.ListaSeries[0].Numero;
            }
        }

        public static void Desbloquear(string TipoFactura)
        {
            try
            {
                //buscar el valor y bloquear el registro
                Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
                S.ListaSeries[0].Bloqueado = false;
                S.ListaSeries[0].Comprobante = "'" + S.ListaSeries[0].Comprobante + "'";
                Series.Set(S.ListaSeries[0]);
            }
            catch
            {

            }
        }

        public static void DesbloquearSumar(string TipoFactura)
        {
            //buscar el valor y bloquear el registro
            Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
            S.ListaSeries[0].Bloqueado = false;
            S.ListaSeries[0].Numero++;
            S.ListaSeries[0].Comprobante = "'" + S.ListaSeries[0].Comprobante + "'";
            Series.Set(S.ListaSeries[0]);
        }

        public static int BloquearSinTransaccion(string TipoFactura)
        {
            //buscar el valor y bloquear el registro
            Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
            if (S.ListaSeries[0].Bloqueado)
            {
                throw new Exception("Este tipo de comprobante esta siendo usado.");
            }
            else
            {
                S.ListaSeries[0].Bloqueado = true;
                S.ListaSeries[0].Comprobante = "'" + S.ListaSeries[0].Comprobante + "'";
                Series.SetSinTransaccion(S.ListaSeries[0]);
                return S.ListaSeries[0].Numero;
            }
        }

        public static void DesbloquearSinTransaccion(string TipoFactura)
        {
            //buscar el valor y bloquear el registro
            Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
            S.ListaSeries[0].Bloqueado = false;
            S.ListaSeries[0].Comprobante = "'" + S.ListaSeries[0].Comprobante + "'";
            Series.SetSinTransaccion(S.ListaSeries[0]);
        }

        public static void DesbloquearSumarSinTransaccion(string TipoFactura)
        {
            //buscar el valor y bloquear el registro
            Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
            S.ListaSeries[0].Bloqueado = false;
            S.ListaSeries[0].Numero++;
            S.ListaSeries[0].Comprobante = "'" + S.ListaSeries[0].Comprobante + "'";
            Series.SetSinTransaccion(S.ListaSeries[0]);
        }

        /// <summary>
        /// Actualiza un fila a la tabla Series. es para actualizar, le pone las comillas para que no dee error en el "where"
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Series</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetComillas(Series Obj)
        {
            if (Obj.Comprobante == null)
            {
                throw new Exception("Comprobante no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE series SET `Numero` =  '" + Obj.Numero.ToString() + "', `Bloqueado` = " + Common.BoolToString(Obj.Bloqueado) + " WHERE series.Comprobante = '" + Obj.Comprobante.ToString() + "';"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    public partial class Tercero
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdTercero">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tercero GetTercero(string IdTercero, string TipoTercero)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdTercero != "")
            {
                Filtro += "AND Id_Tercero = " + IdTercero + " ";
            }
            if (TipoTercero != "")
            {
                Filtro += "AND Id_Tercero_Tipo = " + TipoTercero + " ";
            }
            return new Tercero(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdTercero">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tercero GetTerceroRelacional(string IdTercero, string TipoTercero, string RazonSocial)
        {
            string SqlString = "SELECT tercero.Id_Tercero, tercero.Id_Tercero_Tipo, tercero.Id_Tercero_IVA, tercero.Id_Localidad, tercero.Razon_Social_Tercero, tercero.Direccion_Tercero, tercero.Fecha_Nacimiento_Tercero, tercero.CUIT_Tercero, tercero.Telefonos_Tercero, tercero.DNI_Tercero, tercero.Fax_Tercero, tercero.Email_Tercero, tercero.Fecha_Alta_Tercero, tercero.Fecha_Baja_Tercero, tercero.Anulado_Tercero, tercero.Observaciones_Tercero, tercero_tipo.Id_Tercero_Tipo, tercero_tipo.Descripcion_Tercero_Tipo, tercero_iva.Id_Tercero_IVA, tercero_iva.Descripcion_Tercero_IVA, tercero_iva.Abreviacion_Tercero_IVA, tercero_iva.Clase_Comprobante_Compra_Tercero_IVA, tercero_iva.Clase_Comprobante_Venta_Tercero_IVA, localidad.Id_Localidad, localidad.Id_Provincia, localidad.Nombre_Localidad, localidad.Codigo_Postal_Localidad FROM tercero INNER JOIN tercero_iva ON (tercero.Id_Tercero_IVA = tercero_iva.Id_Tercero_IVA) INNER JOIN localidad ON (tercero.Id_Localidad = localidad.Id_Localidad) INNER JOIN tercero_tipo ON (tercero.Id_Tercero_Tipo = tercero_tipo.Id_Tercero_Tipo)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdTercero != "")
            {
                Filtro += "AND tercero.Id_Tercero = " + IdTercero + " ";
            }
            if (TipoTercero != "")
            {
                Filtro += "AND tercero.Id_Tercero_Tipo = " + TipoTercero + " ";
            }
            if (RazonSocial != "")
            {
                Filtro += "AND tercero.Razon_Social_Tercero LIKE '%" + RazonSocial.Replace(" ", "%") + "%' ";
            }
            return new Tercero(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Tercero_iva
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdTercero_iva">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tercero_iva GetTercero_iva(string IdTercero_iva)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdTercero_iva != "")
            {
                Filtro += "AND Id_Tercero_iva = " + IdTercero_iva + " ";
            }
            return new Tercero_iva(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Tercero_tipo
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdTercero_tipo">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tercero_tipo GetTercero_tipo(string IdTercero_tipo)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdTercero_tipo != "")
            {
                Filtro += "AND Id_Tercero_tipo = " + IdTercero_tipo + " ";
            }
            return new Tercero_tipo(Common.Peticion(GetSelect(Filtro)));
        }
    }
}