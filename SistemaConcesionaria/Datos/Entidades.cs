using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Concesionarias.Datos
{
    /// <summary>
    /// Comentarios de la tabla: Articulos del sistema
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 06:34:08 p.m.
    /// </summary>
    public partial class Articulo
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Articulo()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Articulo</param>
        public Articulo(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Articulo"))
            {
                if (DataRowConstructor["Id_Articulo"] != DBNull.Value)
                {
                    this.Id_Articulo = Convert.ToInt32(DataRowConstructor["Id_Articulo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero"))
            {
                if (DataRowConstructor["Id_Tercero"] != DBNull.Value)
                {
                    this.Id_Tercero = Convert.ToInt32(DataRowConstructor["Id_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Linea"))
            {
                if (DataRowConstructor["Id_Linea"] != DBNull.Value)
                {
                    this.Id_Linea = Convert.ToInt32(DataRowConstructor["Id_Linea"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Categoria"))
            {
                if (DataRowConstructor["Id_Categoria"] != DBNull.Value)
                {
                    this.Id_Categoria = Convert.ToInt32(DataRowConstructor["Id_Categoria"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Codigo_Articulo"))
            {
                if (DataRowConstructor["Codigo_Articulo"] != DBNull.Value)
                {
                    this.Codigo_Articulo = DataRowConstructor["Codigo_Articulo"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Chasis_Articulo"))
            {
                if (DataRowConstructor["Numero_Chasis_Articulo"] != DBNull.Value)
                {
                    this.Numero_Chasis_Articulo = DataRowConstructor["Numero_Chasis_Articulo"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Motor_Articulo"))
            {
                if (DataRowConstructor["Numero_Motor_Articulo"] != DBNull.Value)
                {
                    this.Numero_Motor_Articulo = DataRowConstructor["Numero_Motor_Articulo"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Certificado_Fabricacion_Articulo"))
            {
                if (DataRowConstructor["Certificado_Fabricacion_Articulo"] != DBNull.Value)
                {
                    this.Certificado_Fabricacion_Articulo = DataRowConstructor["Certificado_Fabricacion_Articulo"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Aduana_Articulo"))
            {
                if (DataRowConstructor["Numero_Aduana_Articulo"] != DBNull.Value)
                {
                    this.Numero_Aduana_Articulo = DataRowConstructor["Numero_Aduana_Articulo"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Articulo"))
            {
                if (DataRowConstructor["Descripcion_Articulo"] != DBNull.Value)
                {
                    this.Descripcion_Articulo = DataRowConstructor["Descripcion_Articulo"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Anulado_Articulo"))
            {
                if (DataRowConstructor["Anulado_Articulo"] != DBNull.Value)
                {
                    this.Anulado_Articulo = Convert.ToBoolean(DataRowConstructor["Anulado_Articulo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Stock_Minimo_Articulo"))
            {
                if (DataRowConstructor["Stock_Minimo_Articulo"] != DBNull.Value)
                {
                    this.Stock_Minimo_Articulo = Convert.ToInt32(DataRowConstructor["Stock_Minimo_Articulo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Stock_Articulo"))
            {
                if (DataRowConstructor["Stock_Articulo"] != DBNull.Value)
                {
                    this.Stock_Articulo = Convert.ToInt32(DataRowConstructor["Stock_Articulo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Peso_Articulo"))
            {
                if (DataRowConstructor["Peso_Articulo"] != DBNull.Value)
                {
                    this.Peso_Articulo = Convert.ToDecimal(DataRowConstructor["Peso_Articulo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Dia_Compra_Articulo"))
            {
                if (DataRowConstructor["Dia_Compra_Articulo"] != DBNull.Value)
                {
                    this.Dia_Compra_Articulo = Convert.ToDateTime(DataRowConstructor["Dia_Compra_Articulo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Dia_Venta_Articulo"))
            {
                if (DataRowConstructor["Dia_Venta_Articulo"] != DBNull.Value)
                {
                    this.Dia_Venta_Articulo = Convert.ToDateTime(DataRowConstructor["Dia_Venta_Articulo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Precio_Costo_Articulo"))
            {
                if (DataRowConstructor["Precio_Costo_Articulo"] != DBNull.Value)
                {
                    this.Precio_Costo_Articulo = Convert.ToDecimal(DataRowConstructor["Precio_Costo_Articulo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Precio_Venta_Articulo"))
            {
                if (DataRowConstructor["Precio_Venta_Articulo"] != DBNull.Value)
                {
                    this.Precio_Venta_Articulo = Convert.ToDecimal(DataRowConstructor["Precio_Venta_Articulo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("IVA_Articulo"))
            {
                if (DataRowConstructor["IVA_Articulo"] != DBNull.Value)
                {
                    this.IVA_Articulo = Convert.ToDecimal(DataRowConstructor["IVA_Articulo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Garantia_Articulo"))
            {
                if (DataRowConstructor["Garantia_Articulo"] != DBNull.Value)
                {
                    this.Garantia_Articulo = Convert.ToInt32(DataRowConstructor["Garantia_Articulo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Dominio_Articulo"))
            {
                if (DataRowConstructor["Dominio_Articulo"] != DBNull.Value)
                {
                    this.Dominio_Articulo = DataRowConstructor["Dominio_Articulo"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("ExTitular"))
            {
                if (DataRowConstructor["ExTitular"] != DBNull.Value)
                {
                    this.ExTitular = DataRowConstructor["ExTitular"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Cuadro"))
            {
                if (DataRowConstructor["Cuadro"] != DBNull.Value)
                {
                    this.Cuadro = DataRowConstructor["Cuadro"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Modelo"))
            {
                if (DataRowConstructor["Modelo"] != DBNull.Value)
                {
                    this.Modelo = DataRowConstructor["Modelo"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Color"))
            {
                if (DataRowConstructor["Color"] != DBNull.Value)
                {
                    this.Color = DataRowConstructor["Color"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Articulo"))
            {
                if (DataRowConstructor["Observaciones_Articulo"] != DBNull.Value)
                {
                    this.Observaciones_Articulo = DataRowConstructor["Observaciones_Articulo"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Articulo</param>
        public Articulo(DataSet DataSetConstructor)
        {
            this.ListaArticulo = new List<Articulo>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Articulo TEMP = new Articulo(Fila);
                TEMP.Tercero = new Tercero(Fila);
                TEMP.Linea = new Linea(Fila);
                TEMP.Categoria = new Categoria(Fila);
                this.ListaArticulo.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Articulo> ListaArticulo { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Articulo { get; set; }
        /// <summary>
        /// Tercero que provee este articulo
        /// </summary>
        public int Id_Tercero { get; set; }
        /// <summary>
        /// ID de la linea
        /// </summary>
        public int Id_Linea { get; set; }
        /// <summary>
        /// ID de la categoria
        /// </summary>
        public int Id_Categoria { get; set; }
        /// <summary>
        /// Codigo del articulo
        /// </summary>
        public string Codigo_Articulo { get; set; }
        /// <summary>
        /// Numero del chasis, esto es solo para las motos
        /// </summary>
        public string Numero_Chasis_Articulo { get; set; }
        /// <summary>
        /// Numero del motor, esto es solo para las motos
        /// </summary>
        public string Numero_Motor_Articulo { get; set; }
        /// <summary>
        /// Certificado de fabricacion del automotor
        /// </summary>
        public string Certificado_Fabricacion_Articulo { get; set; }
        /// <summary>
        /// Algun numero de control de aduana
        /// </summary>
        public string Numero_Aduana_Articulo { get; set; }
        /// <summary>
        /// Descripcion del articulo
        /// </summary>
        public string Descripcion_Articulo { get; set; }
        /// <summary>
        /// es verdadero si esta anulado
        /// </summary>
        public bool Anulado_Articulo { get; set; }
        /// <summary>
        /// Cantidad minima del articulo
        /// </summary>
        public int Stock_Minimo_Articulo { get; set; }
        /// <summary>
        /// Cantidad de articulos que hay en existencia
        /// </summary>
        public int Stock_Articulo { get; set; }
        /// <summary>
        /// Peso del articulo
        /// </summary>
        public decimal Peso_Articulo { get; set; }
        /// <summary>
        /// Ultimo dia de compra de este articulo
        /// </summary>
        public DateTime Dia_Compra_Articulo { get; set; }
        /// <summary>
        /// Ultimo dia de la venta de este articul
        /// </summary>
        public DateTime Dia_Venta_Articulo { get; set; }
        /// <summary>
        /// Precio de costo de este articulo
        /// </summary>
        public decimal Precio_Costo_Articulo { get; set; }
        /// <summary>
        /// Precio de venta de este articulo
        /// </summary>
        public decimal Precio_Venta_Articulo { get; set; }
        /// <summary>
        /// Porcentaje de IVA de este articulo
        /// </summary>
        public decimal IVA_Articulo { get; set; }
        /// <summary>
        /// Numero de meses de garantia
        /// </summary>
        public int Garantia_Articulo { get; set; }
        /// <summary>
        /// Dominio del ciclomotor
        /// </summary>
        public string Dominio_Articulo { get; set; }
        /// <summary>
        /// Extitular del ciclomotor
        /// </summary>
        public string ExTitular { get; set; }
        /// <summary>
        /// Cuadro
        /// </summary>
        public string Cuadro { get; set; }
        /// <summary>
        /// Modelo
        /// </summary>
        public string Modelo { get; set; }
        /// <summary>
        /// Color
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Observaciones del articulo
        /// </summary>
        public string Observaciones_Articulo { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero, Guarda los cliente y los proveedores
        /// </summary>
        public Tercero Tercero { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Linea, Linea de los articulos
        /// </summary>
        public Linea Linea { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Categoria, Categorias de los articulos
        /// </summary>
        public Categoria Categoria { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla articulo.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Articulo`, `Id_Tercero`, `Id_Linea`, `Id_Categoria`, `Codigo_Articulo`, `Numero_Chasis_Articulo`, `Numero_Motor_Articulo`, `Certificado_Fabricacion_Articulo`, `Numero_Aduana_Articulo`, `Descripcion_Articulo`, `Anulado_Articulo`, `Stock_Minimo_Articulo`, `Stock_Articulo`, `Peso_Articulo`, `Dia_Compra_Articulo`, `Dia_Venta_Articulo`, `Precio_Costo_Articulo`, `Precio_Venta_Articulo`, `IVA_Articulo`, `Garantia_Articulo`, `Dominio_Articulo`, `ExTitular`, `Cuadro`, `Modelo`, `Color`, `Observaciones_Articulo` FROM articulo " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla articulo.
        /// </summary>
        /// <param name="Id_Articulo">ID de la tabla</param>
        /// <param name="Id_Tercero">Tercero que provee este articulo</param>
        /// <param name="Id_Linea">ID de la linea</param>
        /// <param name="Id_Categoria">ID de la categoria</param>
        /// <param name="Codigo_Articulo">Codigo del articulo</param>
        /// <param name="Numero_Chasis_Articulo">Numero del chasis, esto es solo para las motos</param>
        /// <param name="Numero_Motor_Articulo">Numero del motor, esto es solo para las motos</param>
        /// <param name="Certificado_Fabricacion_Articulo">Certificado de fabricacion del automotor</param>
        /// <param name="Numero_Aduana_Articulo">Algun numero de control de aduana</param>
        /// <param name="Descripcion_Articulo">Descripcion del articulo</param>
        /// <param name="Anulado_Articulo">es verdadero si esta anulado</param>
        /// <param name="Stock_Minimo_Articulo">Cantidad minima del articulo</param>
        /// <param name="Stock_Articulo">Cantidad de articulos que hay en existencia</param>
        /// <param name="Peso_Articulo">Peso del articulo</param>
        /// <param name="Dia_Compra_Articulo">Ultimo dia de compra de este articulo</param>
        /// <param name="Dia_Venta_Articulo">Ultimo dia de la venta de este articul</param>
        /// <param name="Precio_Costo_Articulo">Precio de costo de este articulo</param>
        /// <param name="Precio_Venta_Articulo">Precio de venta de este articulo</param>
        /// <param name="IVA_Articulo">Porcentaje de IVA de este articulo</param>
        /// <param name="Garantia_Articulo">Numero de meses de garantia</param>
        /// <param name="Dominio_Articulo">Dominio del ciclomotor</param>
        /// <param name="ExTitular">Extitular del ciclomotor</param>
        /// <param name="Cuadro">Cuadro</param>
        /// <param name="Modelo">Modelo</param>
        /// <param name="Color">Color</param>
        /// <param name="Observaciones_Articulo">Observaciones del articulo</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Articulo, int Id_Tercero, int Id_Linea, int Id_Categoria, string Codigo_Articulo, string Numero_Chasis_Articulo, string Numero_Motor_Articulo, string Certificado_Fabricacion_Articulo, string Numero_Aduana_Articulo, string Descripcion_Articulo, bool Anulado_Articulo, int Stock_Minimo_Articulo, int Stock_Articulo, decimal Peso_Articulo, DateTime Dia_Compra_Articulo, DateTime Dia_Venta_Articulo, decimal Precio_Costo_Articulo, decimal Precio_Venta_Articulo, decimal IVA_Articulo, int Garantia_Articulo, string Dominio_Articulo, string ExTitular, string Cuadro, string Modelo, string Color, string Observaciones_Articulo)
        {
            return "INSERT INTO articulo(`Id_Articulo`, `Id_Tercero`, `Id_Linea`, `Id_Categoria`, `Codigo_Articulo`, `Numero_Chasis_Articulo`, `Numero_Motor_Articulo`, `Certificado_Fabricacion_Articulo`, `Numero_Aduana_Articulo`, `Descripcion_Articulo`, `Anulado_Articulo`, `Stock_Minimo_Articulo`, `Stock_Articulo`, `Peso_Articulo`, `Dia_Compra_Articulo`, `Dia_Venta_Articulo`, `Precio_Costo_Articulo`, `Precio_Venta_Articulo`, `IVA_Articulo`, `Garantia_Articulo`, `Dominio_Articulo`, `ExTitular`, `Cuadro`, `Modelo`, `Color`, `Observaciones_Articulo`) VALUES ('" + Id_Articulo.ToString() + "', '" + Id_Tercero.ToString() + "', '" + Id_Linea.ToString() + "', '" + Id_Categoria.ToString() + "', '" + Codigo_Articulo.ToString() + "', '" + Numero_Chasis_Articulo.ToString() + "', '" + Numero_Motor_Articulo.ToString() + "', '" + Certificado_Fabricacion_Articulo.ToString() + "', '" + Numero_Aduana_Articulo.ToString() + "', '" + Descripcion_Articulo.ToString() + "', '" + Anulado_Articulo.ToString() + "', '" + Stock_Minimo_Articulo.ToString() + "', '" + Stock_Articulo.ToString() + "', '" + Peso_Articulo.ToString() + "', '" + Dia_Compra_Articulo.ToString() + "', '" + Dia_Venta_Articulo.ToString() + "', '" + Precio_Costo_Articulo.ToString() + "', '" + Precio_Venta_Articulo.ToString() + "', '" + IVA_Articulo.ToString() + "', '" + Garantia_Articulo.ToString() + "', '" + Dominio_Articulo.ToString() + "', '" + ExTitular.ToString() + "', '" + Cuadro.ToString() + "', '" + Modelo.ToString() + "', '" + Color.ToString() + "', '" + Observaciones_Articulo.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla articulo.
        /// </summary>
        /// <param name="Id_Articulo">ID de la tabla</param>
        /// <param name="Id_Tercero">Tercero que provee este articulo</param>
        /// <param name="Id_Linea">ID de la linea</param>
        /// <param name="Id_Categoria">ID de la categoria</param>
        /// <param name="Codigo_Articulo">Codigo del articulo</param>
        /// <param name="Numero_Chasis_Articulo">Numero del chasis, esto es solo para las motos</param>
        /// <param name="Numero_Motor_Articulo">Numero del motor, esto es solo para las motos</param>
        /// <param name="Certificado_Fabricacion_Articulo">Certificado de fabricacion del automotor</param>
        /// <param name="Numero_Aduana_Articulo">Algun numero de control de aduana</param>
        /// <param name="Descripcion_Articulo">Descripcion del articulo</param>
        /// <param name="Anulado_Articulo">es verdadero si esta anulado</param>
        /// <param name="Stock_Minimo_Articulo">Cantidad minima del articulo</param>
        /// <param name="Stock_Articulo">Cantidad de articulos que hay en existencia</param>
        /// <param name="Peso_Articulo">Peso del articulo</param>
        /// <param name="Dia_Compra_Articulo">Ultimo dia de compra de este articulo</param>
        /// <param name="Dia_Venta_Articulo">Ultimo dia de la venta de este articul</param>
        /// <param name="Precio_Costo_Articulo">Precio de costo de este articulo</param>
        /// <param name="Precio_Venta_Articulo">Precio de venta de este articulo</param>
        /// <param name="IVA_Articulo">Porcentaje de IVA de este articulo</param>
        /// <param name="Garantia_Articulo">Numero de meses de garantia</param>
        /// <param name="Dominio_Articulo">Dominio del ciclomotor</param>
        /// <param name="ExTitular">Extitular del ciclomotor</param>
        /// <param name="Cuadro">Cuadro</param>
        /// <param name="Modelo">Modelo</param>
        /// <param name="Color">Color</param>
        /// <param name="Observaciones_Articulo">Observaciones del articulo</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Articulo, int Id_Tercero, int Id_Linea, int Id_Categoria, string Codigo_Articulo, string Numero_Chasis_Articulo, string Numero_Motor_Articulo, string Certificado_Fabricacion_Articulo, string Numero_Aduana_Articulo, string Descripcion_Articulo, bool Anulado_Articulo, int Stock_Minimo_Articulo, int Stock_Articulo, decimal Peso_Articulo, DateTime Dia_Compra_Articulo, DateTime Dia_Venta_Articulo, decimal Precio_Costo_Articulo, decimal Precio_Venta_Articulo, decimal IVA_Articulo, int Garantia_Articulo, string Dominio_Articulo, string ExTitular, string Cuadro, string Modelo, string Color, string Observaciones_Articulo, string Filtro)
        {
            return "UPDATE articulo SET `Id_Articulo` = '" + Id_Articulo.ToString() + "', `Id_Tercero` = '" + Id_Tercero.ToString() + "', `Id_Linea` = '" + Id_Linea.ToString() + "', `Id_Categoria` = '" + Id_Categoria.ToString() + "', `Codigo_Articulo` = '" + Codigo_Articulo.ToString() + "', `Numero_Chasis_Articulo` = '" + Numero_Chasis_Articulo.ToString() + "', `Numero_Motor_Articulo` = '" + Numero_Motor_Articulo.ToString() + "', `Certificado_Fabricacion_Articulo` = '" + Certificado_Fabricacion_Articulo.ToString() + "', `Numero_Aduana_Articulo` = '" + Numero_Aduana_Articulo.ToString() + "', `Descripcion_Articulo` = '" + Descripcion_Articulo.ToString() + "', `Anulado_Articulo` = '" + Anulado_Articulo.ToString() + "', `Stock_Minimo_Articulo` = '" + Stock_Minimo_Articulo.ToString() + "', `Stock_Articulo` = '" + Stock_Articulo.ToString() + "', `Peso_Articulo` = '" + Peso_Articulo.ToString() + "', `Dia_Compra_Articulo` = '" + Dia_Compra_Articulo.ToString() + "', `Dia_Venta_Articulo` = '" + Dia_Venta_Articulo.ToString() + "', `Precio_Costo_Articulo` = '" + Precio_Costo_Articulo.ToString() + "', `Precio_Venta_Articulo` = '" + Precio_Venta_Articulo.ToString() + "', `IVA_Articulo` = '" + IVA_Articulo.ToString() + "', `Garantia_Articulo` = '" + Garantia_Articulo.ToString() + "', `Dominio_Articulo` = '" + Dominio_Articulo.ToString() + "', `ExTitular` = '" + ExTitular.ToString() + "', `Cuadro` = '" + Cuadro.ToString() + "', `Modelo` = '" + Modelo.ToString() + "', `Color` = '" + Color.ToString() + "', `Observaciones_Articulo` = '" + Observaciones_Articulo.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Articulo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Articulo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Articulo Obj)
        {
            if (Obj.Codigo_Articulo == null)
            {
                throw new Exception("Codigo_Articulo no puede ser null");
            }
            if (Obj.Numero_Chasis_Articulo == null)
            {
                throw new Exception("Numero_Chasis_Articulo no puede ser null");
            }
            if (Obj.Numero_Motor_Articulo == null)
            {
                throw new Exception("Numero_Motor_Articulo no puede ser null");
            }
            if (Obj.Certificado_Fabricacion_Articulo == null)
            {
                throw new Exception("Certificado_Fabricacion_Articulo no puede ser null");
            }
            if (Obj.Numero_Aduana_Articulo == null)
            {
                throw new Exception("Numero_Aduana_Articulo no puede ser null");
            }
            if (Obj.Descripcion_Articulo == null)
            {
                throw new Exception("Descripcion_Articulo no puede ser null");
            }
            if (Obj.Dia_Compra_Articulo == null)
            {
                throw new Exception("Dia_Compra_Articulo no puede ser null");
            }
            if (Obj.Dia_Venta_Articulo == null)
            {
                throw new Exception("Dia_Venta_Articulo no puede ser null");
            }
            if (Obj.Dominio_Articulo == null)
            {
                throw new Exception("Dominio_Articulo no puede ser null");
            }
            if (Obj.ExTitular == null)
            {
                throw new Exception("ExTitular no puede ser null");
            }
            if (Obj.Cuadro == null)
            {
                throw new Exception("Cuadro no puede ser null");
            }
            if (Obj.Modelo == null)
            {
                throw new Exception("Modelo no puede ser null");
            }
            if (Obj.Color == null)
            {
                throw new Exception("Color no puede ser null");
            }
            if (Obj.Observaciones_Articulo == null)
            {
                throw new Exception("Observaciones_Articulo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO articulo(`Id_Tercero`, `Id_Linea`, `Id_Categoria`, `Codigo_Articulo`, `Numero_Chasis_Articulo`, `Numero_Motor_Articulo`, `Certificado_Fabricacion_Articulo`, `Numero_Aduana_Articulo`, `Descripcion_Articulo`, `Anulado_Articulo`, `Stock_Minimo_Articulo`, `Stock_Articulo`, `Peso_Articulo`, `Dia_Compra_Articulo`, `Dia_Venta_Articulo`, `Precio_Costo_Articulo`, `Precio_Venta_Articulo`, `IVA_Articulo`, `Garantia_Articulo`, `Dominio_Articulo`, `ExTitular`, `Cuadro`, `Modelo`, `Color`, `Observaciones_Articulo`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Id_Linea.ToString() + "', " + "'" + Obj.Id_Categoria.ToString() + "', " + "'" + Obj.Codigo_Articulo + "', " + "'" + Obj.Numero_Chasis_Articulo + "', " + "'" + Obj.Numero_Motor_Articulo + "', " + "'" + Obj.Certificado_Fabricacion_Articulo + "', " + "'" + Obj.Numero_Aduana_Articulo + "', " + "'" + Obj.Descripcion_Articulo + "', " + Common.BoolToString(Obj.Anulado_Articulo) + ", " + "'" + Obj.Stock_Minimo_Articulo.ToString() + "', " + "'" + Obj.Stock_Articulo.ToString() + "', " + "'" + Obj.Peso_Articulo.ToString().Replace(",", ".") + "', " + "'" + Obj.Dia_Compra_Articulo.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Dia_Venta_Articulo.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Precio_Costo_Articulo.ToString().Replace(",", ".") + "', " + "'" + Obj.Precio_Venta_Articulo.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_Articulo.ToString().Replace(",", ".") + "', " + "'" + Obj.Garantia_Articulo.ToString() + "', " + "'" + Obj.Dominio_Articulo + "', " + "'" + Obj.ExTitular + "', " + "'" + Obj.Cuadro + "', " + "'" + Obj.Modelo + "', " + "'" + Obj.Color + "', " + "'" + Obj.Observaciones_Articulo + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Articulo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Articulo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Articulo Obj)
        {
            if (Obj.Codigo_Articulo == null)
            {
                throw new Exception("Codigo_Articulo no puede ser null");
            }
            if (Obj.Numero_Chasis_Articulo == null)
            {
                throw new Exception("Numero_Chasis_Articulo no puede ser null");
            }
            if (Obj.Numero_Motor_Articulo == null)
            {
                throw new Exception("Numero_Motor_Articulo no puede ser null");
            }
            if (Obj.Certificado_Fabricacion_Articulo == null)
            {
                throw new Exception("Certificado_Fabricacion_Articulo no puede ser null");
            }
            if (Obj.Numero_Aduana_Articulo == null)
            {
                throw new Exception("Numero_Aduana_Articulo no puede ser null");
            }
            if (Obj.Descripcion_Articulo == null)
            {
                throw new Exception("Descripcion_Articulo no puede ser null");
            }
            if (Obj.Dia_Compra_Articulo == null)
            {
                throw new Exception("Dia_Compra_Articulo no puede ser null");
            }
            if (Obj.Dia_Venta_Articulo == null)
            {
                throw new Exception("Dia_Venta_Articulo no puede ser null");
            }
            if (Obj.Dominio_Articulo == null)
            {
                throw new Exception("Dominio_Articulo no puede ser null");
            }
            if (Obj.ExTitular == null)
            {
                throw new Exception("ExTitular no puede ser null");
            }
            if (Obj.Cuadro == null)
            {
                throw new Exception("Cuadro no puede ser null");
            }
            if (Obj.Modelo == null)
            {
                throw new Exception("Modelo no puede ser null");
            }
            if (Obj.Color == null)
            {
                throw new Exception("Color no puede ser null");
            }
            if (Obj.Observaciones_Articulo == null)
            {
                throw new Exception("Observaciones_Articulo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE articulo SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Id_Linea` =  '" + Obj.Id_Linea.ToString() + "', `Id_Categoria` =  '" + Obj.Id_Categoria.ToString() + "', `Codigo_Articulo` =  '" + Obj.Codigo_Articulo + "', `Numero_Chasis_Articulo` =  '" + Obj.Numero_Chasis_Articulo + "', `Numero_Motor_Articulo` =  '" + Obj.Numero_Motor_Articulo + "', `Certificado_Fabricacion_Articulo` =  '" + Obj.Certificado_Fabricacion_Articulo + "', `Numero_Aduana_Articulo` =  '" + Obj.Numero_Aduana_Articulo + "', `Descripcion_Articulo` =  '" + Obj.Descripcion_Articulo + "', `Anulado_Articulo` = " + Common.BoolToString(Obj.Anulado_Articulo) + ", `Stock_Minimo_Articulo` =  '" + Obj.Stock_Minimo_Articulo.ToString() + "', `Stock_Articulo` =  '" + Obj.Stock_Articulo.ToString() + "', `Peso_Articulo` =  '" + Obj.Peso_Articulo.ToString().Replace(",", ".") + "', `Dia_Compra_Articulo` =  '" + Obj.Dia_Compra_Articulo.ToString("yyyy-MM-dd HH:mm:ss") + "', `Dia_Venta_Articulo` =  '" + Obj.Dia_Venta_Articulo.ToString("yyyy-MM-dd HH:mm:ss") + "', `Precio_Costo_Articulo` =  '" + Obj.Precio_Costo_Articulo.ToString().Replace(",", ".") + "', `Precio_Venta_Articulo` =  '" + Obj.Precio_Venta_Articulo.ToString().Replace(",", ".") + "', `IVA_Articulo` =  '" + Obj.IVA_Articulo.ToString().Replace(",", ".") + "', `Garantia_Articulo` =  '" + Obj.Garantia_Articulo.ToString() + "', `Dominio_Articulo` =  '" + Obj.Dominio_Articulo + "', `ExTitular` =  '" + Obj.ExTitular + "', `Cuadro` =  '" + Obj.Cuadro + "', `Modelo` =  '" + Obj.Modelo + "', `Color` =  '" + Obj.Color + "', `Observaciones_Articulo` =  '" + Obj.Observaciones_Articulo + "' WHERE articulo.Id_Articulo = " + Obj.Id_Articulo.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Articulo.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM articulo WHERE articulo.Id_Articulo = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Articulo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Articulo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Articulo Obj)
        {
            if (Obj.Codigo_Articulo == null)
            {
                throw new Exception("Codigo_Articulo no puede ser null");
            }
            if (Obj.Numero_Chasis_Articulo == null)
            {
                throw new Exception("Numero_Chasis_Articulo no puede ser null");
            }
            if (Obj.Numero_Motor_Articulo == null)
            {
                throw new Exception("Numero_Motor_Articulo no puede ser null");
            }
            if (Obj.Certificado_Fabricacion_Articulo == null)
            {
                throw new Exception("Certificado_Fabricacion_Articulo no puede ser null");
            }
            if (Obj.Numero_Aduana_Articulo == null)
            {
                throw new Exception("Numero_Aduana_Articulo no puede ser null");
            }
            if (Obj.Descripcion_Articulo == null)
            {
                throw new Exception("Descripcion_Articulo no puede ser null");
            }
            if (Obj.Dia_Compra_Articulo == null)
            {
                throw new Exception("Dia_Compra_Articulo no puede ser null");
            }
            if (Obj.Dia_Venta_Articulo == null)
            {
                throw new Exception("Dia_Venta_Articulo no puede ser null");
            }
            if (Obj.Dominio_Articulo == null)
            {
                throw new Exception("Dominio_Articulo no puede ser null");
            }
            if (Obj.ExTitular == null)
            {
                throw new Exception("ExTitular no puede ser null");
            }
            if (Obj.Cuadro == null)
            {
                throw new Exception("Cuadro no puede ser null");
            }
            if (Obj.Modelo == null)
            {
                throw new Exception("Modelo no puede ser null");
            }
            if (Obj.Color == null)
            {
                throw new Exception("Color no puede ser null");
            }
            if (Obj.Observaciones_Articulo == null)
            {
                throw new Exception("Observaciones_Articulo no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO articulo(`Id_Tercero`, `Id_Linea`, `Id_Categoria`, `Codigo_Articulo`, `Numero_Chasis_Articulo`, `Numero_Motor_Articulo`, `Certificado_Fabricacion_Articulo`, `Numero_Aduana_Articulo`, `Descripcion_Articulo`, `Anulado_Articulo`, `Stock_Minimo_Articulo`, `Stock_Articulo`, `Peso_Articulo`, `Dia_Compra_Articulo`, `Dia_Venta_Articulo`, `Precio_Costo_Articulo`, `Precio_Venta_Articulo`, `IVA_Articulo`, `Garantia_Articulo`, `Dominio_Articulo`, `ExTitular`, `Cuadro`, `Modelo`, `Color`, `Observaciones_Articulo`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Id_Linea.ToString() + "', " + "'" + Obj.Id_Categoria.ToString() + "', " + "'" + Obj.Codigo_Articulo + "', " + "'" + Obj.Numero_Chasis_Articulo + "', " + "'" + Obj.Numero_Motor_Articulo + "', " + "'" + Obj.Certificado_Fabricacion_Articulo + "', " + "'" + Obj.Numero_Aduana_Articulo + "', " + "'" + Obj.Descripcion_Articulo + "', " + Common.BoolToString(Obj.Anulado_Articulo) + ", " + "'" + Obj.Stock_Minimo_Articulo.ToString() + "', " + "'" + Obj.Stock_Articulo.ToString() + "', " + "'" + Obj.Peso_Articulo.ToString().Replace(",", ".") + "', " + "'" + Obj.Dia_Compra_Articulo.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Dia_Venta_Articulo.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Precio_Costo_Articulo.ToString().Replace(",", ".") + "', " + "'" + Obj.Precio_Venta_Articulo.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_Articulo.ToString().Replace(",", ".") + "', " + "'" + Obj.Garantia_Articulo.ToString() + "', " + "'" + Obj.Dominio_Articulo + "', " + "'" + Obj.ExTitular + "', " + "'" + Obj.Cuadro + "', " + "'" + Obj.Modelo + "', " + "'" + Obj.Color + "', " + "'" + Obj.Observaciones_Articulo + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Articulo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Articulo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Articulo Obj)
        {
            if (Obj.Codigo_Articulo == null)
            {
                throw new Exception("Codigo_Articulo no puede ser null");
            }
            if (Obj.Numero_Chasis_Articulo == null)
            {
                throw new Exception("Numero_Chasis_Articulo no puede ser null");
            }
            if (Obj.Numero_Motor_Articulo == null)
            {
                throw new Exception("Numero_Motor_Articulo no puede ser null");
            }
            if (Obj.Certificado_Fabricacion_Articulo == null)
            {
                throw new Exception("Certificado_Fabricacion_Articulo no puede ser null");
            }
            if (Obj.Numero_Aduana_Articulo == null)
            {
                throw new Exception("Numero_Aduana_Articulo no puede ser null");
            }
            if (Obj.Descripcion_Articulo == null)
            {
                throw new Exception("Descripcion_Articulo no puede ser null");
            }
            if (Obj.Dia_Compra_Articulo == null)
            {
                throw new Exception("Dia_Compra_Articulo no puede ser null");
            }
            if (Obj.Dia_Venta_Articulo == null)
            {
                throw new Exception("Dia_Venta_Articulo no puede ser null");
            }
            if (Obj.Dominio_Articulo == null)
            {
                throw new Exception("Dominio_Articulo no puede ser null");
            }
            if (Obj.ExTitular == null)
            {
                throw new Exception("ExTitular no puede ser null");
            }
            if (Obj.Cuadro == null)
            {
                throw new Exception("Cuadro no puede ser null");
            }
            if (Obj.Modelo == null)
            {
                throw new Exception("Modelo no puede ser null");
            }
            if (Obj.Color == null)
            {
                throw new Exception("Color no puede ser null");
            }
            if (Obj.Observaciones_Articulo == null)
            {
                throw new Exception("Observaciones_Articulo no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE articulo SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Id_Linea` =  '" + Obj.Id_Linea.ToString() + "', `Id_Categoria` =  '" + Obj.Id_Categoria.ToString() + "', `Codigo_Articulo` =  '" + Obj.Codigo_Articulo + "', `Numero_Chasis_Articulo` =  '" + Obj.Numero_Chasis_Articulo + "', `Numero_Motor_Articulo` =  '" + Obj.Numero_Motor_Articulo + "', `Certificado_Fabricacion_Articulo` =  '" + Obj.Certificado_Fabricacion_Articulo + "', `Numero_Aduana_Articulo` =  '" + Obj.Numero_Aduana_Articulo + "', `Descripcion_Articulo` =  '" + Obj.Descripcion_Articulo + "', `Anulado_Articulo` = " + Common.BoolToString(Obj.Anulado_Articulo) + ", `Stock_Minimo_Articulo` =  '" + Obj.Stock_Minimo_Articulo.ToString() + "', `Stock_Articulo` =  '" + Obj.Stock_Articulo.ToString() + "', `Peso_Articulo` =  '" + Obj.Peso_Articulo.ToString().Replace(",", ".") + "', `Dia_Compra_Articulo` =  '" + Obj.Dia_Compra_Articulo.ToString("yyyy-MM-dd HH:mm:ss") + "', `Dia_Venta_Articulo` =  '" + Obj.Dia_Venta_Articulo.ToString("yyyy-MM-dd HH:mm:ss") + "', `Precio_Costo_Articulo` =  '" + Obj.Precio_Costo_Articulo.ToString().Replace(",", ".") + "', `Precio_Venta_Articulo` =  '" + Obj.Precio_Venta_Articulo.ToString().Replace(",", ".") + "', `IVA_Articulo` =  '" + Obj.IVA_Articulo.ToString().Replace(",", ".") + "', `Garantia_Articulo` =  '" + Obj.Garantia_Articulo.ToString() + "', `Dominio_Articulo` =  '" + Obj.Dominio_Articulo + "', `ExTitular` =  '" + Obj.ExTitular + "', `Cuadro` =  '" + Obj.Cuadro + "', `Modelo` =  '" + Obj.Modelo + "', `Color` =  '" + Obj.Color + "', `Observaciones_Articulo` =  '" + Obj.Observaciones_Articulo + "' WHERE articulo.Id_Articulo = " + Obj.Id_Articulo.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Articulo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM articulo WHERE articulo.Id_Articulo = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Se guarda todos las salidas y entradas de la caja en efectiv
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:34 a.m.
    /// </summary>
    public partial class Caja
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Caja()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Caja</param>
        public Caja(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Caja"))
            {
                if (DataRowConstructor["Id_Caja"] != DBNull.Value)
                {
                    this.Id_Caja = Convert.ToInt32(DataRowConstructor["Id_Caja"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Caja_Tipo"))
            {
                if (DataRowConstructor["Id_Caja_Tipo"] != DBNull.Value)
                {
                    this.Id_Caja_Tipo = Convert.ToInt32(DataRowConstructor["Id_Caja_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Caja"))
            {
                if (DataRowConstructor["Importe_Caja"] != DBNull.Value)
                {
                    this.Importe_Caja = Convert.ToDecimal(DataRowConstructor["Importe_Caja"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Caja"))
            {
                if (DataRowConstructor["Fecha_Caja"] != DBNull.Value)
                {
                    this.Fecha_Caja = Convert.ToDateTime(DataRowConstructor["Fecha_Caja"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Remito_Caja"))
            {
                if (DataRowConstructor["Numero_Remito_Caja"] != DBNull.Value)
                {
                    this.Numero_Remito_Caja = Convert.ToInt32(DataRowConstructor["Numero_Remito_Caja"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Cuota_Caja"))
            {
                if (DataRowConstructor["Numero_Cuota_Caja"] != DBNull.Value)
                {
                    this.Numero_Cuota_Caja = Convert.ToInt32(DataRowConstructor["Numero_Cuota_Caja"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Tag_Caja"))
            {
                if (DataRowConstructor["Tag_Caja"] != DBNull.Value)
                {
                    this.Tag_Caja = DataRowConstructor["Tag_Caja"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Caja</param>
        public Caja(DataSet DataSetConstructor)
        {
            this.ListaCaja = new List<Caja>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Caja TEMP = new Caja(Fila);
                TEMP.Caja_tipo = new Caja_tipo(Fila);
                this.ListaCaja.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Caja> ListaCaja { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Caja { get; set; }
        /// <summary>
        /// Tipo de caja, define si es entrada o salida
        /// </summary>
        public int Id_Caja_Tipo { get; set; }
        /// <summary>
        /// De cuanto es el movimiento, siempre en pesos
        /// </summary>
        public decimal Importe_Caja { get; set; }
        /// <summary>
        /// Fecha del movimiento
        /// </summary>
        public DateTime Fecha_Caja { get; set; }
        /// <summary>
        /// Numero del remito, si lo tiene
        /// </summary>
        public int Numero_Remito_Caja { get; set; }
        /// <summary>
        /// Numero de cuota de pago del remito
        /// </summary>
        public int Numero_Cuota_Caja { get; set; }
        /// <summary>
        /// Para almacenar datos de la aplicacion
        /// </summary>
        public string Tag_Caja { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Caja_tipo, Para saber que tipo de modificacion se le puede hacer a la c
        /// </summary>
        public Caja_tipo Caja_tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla caja.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Caja`, `Id_Caja_Tipo`, `Importe_Caja`, `Fecha_Caja`, `Numero_Remito_Caja`, `Numero_Cuota_Caja`, `Tag_Caja` FROM caja " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla caja.
        /// </summary>
        /// <param name="Id_Caja">ID de la tabla</param>
        /// <param name="Id_Caja_Tipo">Tipo de caja, define si es entrada o salida</param>
        /// <param name="Importe_Caja">De cuanto es el movimiento, siempre en pesos</param>
        /// <param name="Fecha_Caja">Fecha del movimiento</param>
        /// <param name="Numero_Remito_Caja">Numero del remito, si lo tiene</param>
        /// <param name="Numero_Cuota_Caja">Numero de cuota de pago del remito</param>
        /// <param name="Tag_Caja">Para almacenar datos de la aplicacion</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Caja, int Id_Caja_Tipo, decimal Importe_Caja, DateTime Fecha_Caja, int Numero_Remito_Caja, int Numero_Cuota_Caja, string Tag_Caja)
        {
            return "INSERT INTO caja(`Id_Caja`, `Id_Caja_Tipo`, `Importe_Caja`, `Fecha_Caja`, `Numero_Remito_Caja`, `Numero_Cuota_Caja`, `Tag_Caja`) VALUES ('" + Id_Caja.ToString() + "', '" + Id_Caja_Tipo.ToString() + "', '" + Importe_Caja.ToString() + "', '" + Fecha_Caja.ToString() + "', '" + Numero_Remito_Caja.ToString() + "', '" + Numero_Cuota_Caja.ToString() + "', '" + Tag_Caja.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla caja.
        /// </summary>
        /// <param name="Id_Caja">ID de la tabla</param>
        /// <param name="Id_Caja_Tipo">Tipo de caja, define si es entrada o salida</param>
        /// <param name="Importe_Caja">De cuanto es el movimiento, siempre en pesos</param>
        /// <param name="Fecha_Caja">Fecha del movimiento</param>
        /// <param name="Numero_Remito_Caja">Numero del remito, si lo tiene</param>
        /// <param name="Numero_Cuota_Caja">Numero de cuota de pago del remito</param>
        /// <param name="Tag_Caja">Para almacenar datos de la aplicacion</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Caja, int Id_Caja_Tipo, decimal Importe_Caja, DateTime Fecha_Caja, int Numero_Remito_Caja, int Numero_Cuota_Caja, string Tag_Caja, string Filtro)
        {
            return "UPDATE caja SET `Id_Caja` = '" + Id_Caja.ToString() + "', `Id_Caja_Tipo` = '" + Id_Caja_Tipo.ToString() + "', `Importe_Caja` = '" + Importe_Caja.ToString() + "', `Fecha_Caja` = '" + Fecha_Caja.ToString() + "', `Numero_Remito_Caja` = '" + Numero_Remito_Caja.ToString() + "', `Numero_Cuota_Caja` = '" + Numero_Cuota_Caja.ToString() + "', `Tag_Caja` = '" + Tag_Caja.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Caja.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Caja Obj)
        {
            if (Obj.Fecha_Caja == null)
            {
                throw new Exception("Fecha_Caja no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO caja(`Id_Caja_Tipo`, `Importe_Caja`, `Fecha_Caja`, `Numero_Remito_Caja`, `Numero_Cuota_Caja`, `Tag_Caja`)VALUES( " + "'" + Obj.Id_Caja_Tipo.ToString() + "', " + "'" + Obj.Importe_Caja.ToString().Replace(",", ".") + "', " + "'" + Obj.Fecha_Caja.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Numero_Remito_Caja.ToString() + "', " + "'" + Obj.Numero_Cuota_Caja.ToString() + "', " + "'" + Obj.Tag_Caja + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Caja.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Caja Obj)
        {
            if (Obj.Fecha_Caja == null)
            {
                throw new Exception("Fecha_Caja no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE caja SET `Id_Caja_Tipo` =  '" + Obj.Id_Caja_Tipo.ToString() + "', `Importe_Caja` =  '" + Obj.Importe_Caja.ToString().Replace(",", ".") + "', `Fecha_Caja` =  '" + Obj.Fecha_Caja.ToString("yyyy-MM-dd HH:mm:ss") + "', `Numero_Remito_Caja` =  '" + Obj.Numero_Remito_Caja.ToString() + "', `Numero_Cuota_Caja` =  '" + Obj.Numero_Cuota_Caja.ToString() + "', `Tag_Caja` =  '" + Obj.Tag_Caja + "' WHERE caja.Id_Caja = " + Obj.Id_Caja.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Caja.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM caja WHERE caja.Id_Caja = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Caja. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Caja Obj)
        {
            if (Obj.Fecha_Caja == null)
            {
                throw new Exception("Fecha_Caja no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO caja(`Id_Caja_Tipo`, `Importe_Caja`, `Fecha_Caja`, `Numero_Remito_Caja`, `Numero_Cuota_Caja`, `Tag_Caja`)VALUES( " + "'" + Obj.Id_Caja_Tipo.ToString() + "', " + "'" + Obj.Importe_Caja.ToString().Replace(",", ".") + "', " + "'" + Obj.Fecha_Caja.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Numero_Remito_Caja.ToString() + "', " + "'" + Obj.Numero_Cuota_Caja.ToString() + "', " + "'" + Obj.Tag_Caja + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Caja. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Caja Obj)
        {
            if (Obj.Fecha_Caja == null)
            {
                throw new Exception("Fecha_Caja no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE caja SET `Id_Caja_Tipo` =  '" + Obj.Id_Caja_Tipo.ToString() + "', `Importe_Caja` =  '" + Obj.Importe_Caja.ToString().Replace(",", ".") + "', `Fecha_Caja` =  '" + Obj.Fecha_Caja.ToString("yyyy-MM-dd HH:mm:ss") + "', `Numero_Remito_Caja` =  '" + Obj.Numero_Remito_Caja.ToString() + "', `Numero_Cuota_Caja` =  '" + Obj.Numero_Cuota_Caja.ToString() + "', `Tag_Caja` =  '" + Obj.Tag_Caja + "' WHERE caja.Id_Caja = " + Obj.Id_Caja.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Caja. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM caja WHERE caja.Id_Caja = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Para saber que tipo de modificacion se le puede hacer a la c
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:34 a.m.
    /// </summary>
    public partial class Caja_tipo
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Caja_tipo()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Caja_tipo</param>
        public Caja_tipo(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Caja_Tipo"))
            {
                if (DataRowConstructor["Id_Caja_Tipo"] != DBNull.Value)
                {
                    this.Id_Caja_Tipo = Convert.ToInt32(DataRowConstructor["Id_Caja_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Caja_Tipo"))
            {
                if (DataRowConstructor["Descripcion_Caja_Tipo"] != DBNull.Value)
                {
                    this.Descripcion_Caja_Tipo = DataRowConstructor["Descripcion_Caja_Tipo"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Caja_tipo</param>
        public Caja_tipo(DataSet DataSetConstructor)
        {
            this.ListaCaja_tipo = new List<Caja_tipo>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Caja_tipo TEMP = new Caja_tipo(Fila);
                this.ListaCaja_tipo.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Caja_tipo> ListaCaja_tipo { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Caja_Tipo { get; set; }
        /// <summary>
        /// Descripcion del tipo de caja, con esto se define si es entrada o salida
        /// </summary>
        public string Descripcion_Caja_Tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla caja_tipo.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Caja_Tipo`, `Descripcion_Caja_Tipo` FROM caja_tipo " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla caja_tipo.
        /// </summary>
        /// <param name="Id_Caja_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Caja_Tipo">Descripcion del tipo de caja, con esto se define si es entrada o salida</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Caja_Tipo, string Descripcion_Caja_Tipo)
        {
            return "INSERT INTO caja_tipo(`Id_Caja_Tipo`, `Descripcion_Caja_Tipo`) VALUES ('" + Id_Caja_Tipo.ToString() + "', '" + Descripcion_Caja_Tipo.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla caja_tipo.
        /// </summary>
        /// <param name="Id_Caja_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Caja_Tipo">Descripcion del tipo de caja, con esto se define si es entrada o salida</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Caja_Tipo, string Descripcion_Caja_Tipo, string Filtro)
        {
            return "UPDATE caja_tipo SET `Id_Caja_Tipo` = '" + Id_Caja_Tipo.ToString() + "', `Descripcion_Caja_Tipo` = '" + Descripcion_Caja_Tipo.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Caja_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Caja_tipo Obj)
        {
            if (Obj.Descripcion_Caja_Tipo == null)
            {
                throw new Exception("Descripcion_Caja_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO caja_tipo(`Descripcion_Caja_Tipo`)VALUES( " + "'" + Obj.Descripcion_Caja_Tipo + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Caja_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Caja_tipo Obj)
        {
            if (Obj.Descripcion_Caja_Tipo == null)
            {
                throw new Exception("Descripcion_Caja_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE caja_tipo SET `Descripcion_Caja_Tipo` =  '" + Obj.Descripcion_Caja_Tipo + "' WHERE caja_tipo.Id_Caja_Tipo = " + Obj.Id_Caja_Tipo.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Caja_tipo.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM caja_tipo WHERE caja_tipo.Id_Caja_Tipo = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Caja_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Caja_tipo Obj)
        {
            if (Obj.Descripcion_Caja_Tipo == null)
            {
                throw new Exception("Descripcion_Caja_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO caja_tipo(`Descripcion_Caja_Tipo`)VALUES( " + "'" + Obj.Descripcion_Caja_Tipo + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Caja_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Caja_tipo Obj)
        {
            if (Obj.Descripcion_Caja_Tipo == null)
            {
                throw new Exception("Descripcion_Caja_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE caja_tipo SET `Descripcion_Caja_Tipo` =  '" + Obj.Descripcion_Caja_Tipo + "' WHERE caja_tipo.Id_Caja_Tipo = " + Obj.Id_Caja_Tipo.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Caja_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM caja_tipo WHERE caja_tipo.Id_Caja_Tipo = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Categorias de los articulos
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:34 a.m.
    /// </summary>
    public partial class Categoria
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Categoria()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Categoria</param>
        public Categoria(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Categoria"))
            {
                if (DataRowConstructor["Id_Categoria"] != DBNull.Value)
                {
                    this.Id_Categoria = Convert.ToInt32(DataRowConstructor["Id_Categoria"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Categoria"))
            {
                if (DataRowConstructor["Descripcion_Categoria"] != DBNull.Value)
                {
                    this.Descripcion_Categoria = DataRowConstructor["Descripcion_Categoria"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Categoria</param>
        public Categoria(DataSet DataSetConstructor)
        {
            this.ListaCategoria = new List<Categoria>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Categoria TEMP = new Categoria(Fila);
                this.ListaCategoria.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Categoria> ListaCategoria { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Categoria { get; set; }
        /// <summary>
        /// Descripcion de la categoria
        /// </summary>
        public string Descripcion_Categoria { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla categoria.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Categoria`, `Descripcion_Categoria` FROM categoria " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla categoria.
        /// </summary>
        /// <param name="Id_Categoria">ID de la tabla</param>
        /// <param name="Descripcion_Categoria">Descripcion de la categoria</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Categoria, string Descripcion_Categoria)
        {
            return "INSERT INTO categoria(`Id_Categoria`, `Descripcion_Categoria`) VALUES ('" + Id_Categoria.ToString() + "', '" + Descripcion_Categoria.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla categoria.
        /// </summary>
        /// <param name="Id_Categoria">ID de la tabla</param>
        /// <param name="Descripcion_Categoria">Descripcion de la categoria</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Categoria, string Descripcion_Categoria, string Filtro)
        {
            return "UPDATE categoria SET `Id_Categoria` = '" + Id_Categoria.ToString() + "', `Descripcion_Categoria` = '" + Descripcion_Categoria.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Categoria.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Categoria</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Categoria Obj)
        {
            if (Obj.Descripcion_Categoria == null)
            {
                throw new Exception("Descripcion_Categoria no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO categoria(`Descripcion_Categoria`)VALUES( " + "'" + Obj.Descripcion_Categoria + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Categoria.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Categoria</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Categoria Obj)
        {
            if (Obj.Descripcion_Categoria == null)
            {
                throw new Exception("Descripcion_Categoria no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE categoria SET `Descripcion_Categoria` =  '" + Obj.Descripcion_Categoria + "' WHERE categoria.Id_Categoria = " + Obj.Id_Categoria.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Categoria.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM categoria WHERE categoria.Id_Categoria = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Categoria. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Categoria</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Categoria Obj)
        {
            if (Obj.Descripcion_Categoria == null)
            {
                throw new Exception("Descripcion_Categoria no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO categoria(`Descripcion_Categoria`)VALUES( " + "'" + Obj.Descripcion_Categoria + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Categoria. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Categoria</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Categoria Obj)
        {
            if (Obj.Descripcion_Categoria == null)
            {
                throw new Exception("Descripcion_Categoria no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE categoria SET `Descripcion_Categoria` =  '" + Obj.Descripcion_Categoria + "' WHERE categoria.Id_Categoria = " + Obj.Id_Categoria.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Categoria. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM categoria WHERE categoria.Id_Categoria = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Cheques que entregan como forma de pago los clientes
    /// La última modificación fué el miércoles, 12 de octubre de 2011 a las 10:41:14 a.m.
    /// </summary>
    public partial class Cheque_cartera
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Cheque_cartera()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Cheque_cartera</param>
        public Cheque_cartera(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Cheque_Cartera"))
            {
                if (DataRowConstructor["Id_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Id_Cheque_Cartera = Convert.ToInt32(DataRowConstructor["Id_Cheque_Cartera"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Localidad"))
            {
                if (DataRowConstructor["Id_Localidad"] != DBNull.Value)
                {
                    this.Id_Localidad = Convert.ToInt32(DataRowConstructor["Id_Localidad"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Codigo_Cheque_Cartera"))
            {
                if (DataRowConstructor["Codigo_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Codigo_Cheque_Cartera = DataRowConstructor["Codigo_Cheque_Cartera"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Recibo_Cheque_Cartera"))
            {
                if (DataRowConstructor["Numero_Recibo_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Numero_Recibo_Cheque_Cartera = Convert.ToInt32(DataRowConstructor["Numero_Recibo_Cheque_Cartera"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Nombre_Cheque_Cartera"))
            {
                if (DataRowConstructor["Nombre_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Nombre_Cheque_Cartera = DataRowConstructor["Nombre_Cheque_Cartera"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Emicion_Cheque_Cartera"))
            {
                if (DataRowConstructor["Fecha_Emicion_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Fecha_Emicion_Cheque_Cartera = Convert.ToDateTime(DataRowConstructor["Fecha_Emicion_Cheque_Cartera"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Vencimiento_Cheque_Cartera"))
            {
                if (DataRowConstructor["Fecha_Vencimiento_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Fecha_Vencimiento_Cheque_Cartera = Convert.ToDateTime(DataRowConstructor["Fecha_Vencimiento_Cheque_Cartera"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Nombre_Librador_Cheque_Cartera"))
            {
                if (DataRowConstructor["Nombre_Librador_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Nombre_Librador_Cheque_Cartera = DataRowConstructor["Nombre_Librador_Cheque_Cartera"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Marca_Cheque_Cartera"))
            {
                if (DataRowConstructor["Marca_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Marca_Cheque_Cartera = Convert.ToBoolean(DataRowConstructor["Marca_Cheque_Cartera"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Cheque_Cartera"))
            {
                if (DataRowConstructor["Importe_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Importe_Cheque_Cartera = Convert.ToDecimal(DataRowConstructor["Importe_Cheque_Cartera"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Detalle_Cheque_Cartera"))
            {
                if (DataRowConstructor["Detalle_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Detalle_Cheque_Cartera = DataRowConstructor["Detalle_Cheque_Cartera"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Cheque_cartera</param>
        public Cheque_cartera(DataSet DataSetConstructor)
        {
            this.ListaCheque_cartera = new List<Cheque_cartera>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Cheque_cartera TEMP = new Cheque_cartera(Fila);
                TEMP.Localidad = new Localidad(Fila);
                this.ListaCheque_cartera.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Cheque_cartera> ListaCheque_cartera { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Cheque_Cartera { get; set; }
        /// <summary>
        /// Localidad del cheque
        /// </summary>
        public int Id_Localidad { get; set; }
        /// <summary>
        /// Numero, codigo del cheque
        /// </summary>
        public string Codigo_Cheque_Cartera { get; set; }
        /// <summary>
        /// Numero de recibo con el que entregaron el cheque
        /// </summary>
        public int Numero_Recibo_Cheque_Cartera { get; set; }
        /// <summary>
        /// Nombre del banco de donde sale el cheque
        /// </summary>
        public string Nombre_Cheque_Cartera { get; set; }
        /// <summary>
        /// Fecha de cuando se emite el cheque
        /// </summary>
        public DateTime Fecha_Emicion_Cheque_Cartera { get; set; }
        /// <summary>
        /// Cuando se vence
        /// </summary>
        public DateTime Fecha_Vencimiento_Cheque_Cartera { get; set; }
        /// <summary>
        /// Nombre del que libera el cheque
        /// </summary>
        public string Nombre_Librador_Cheque_Cartera { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Marca_Cheque_Cartera { get; set; }
        /// <summary>
        /// Importe del cheque
        /// </summary>
        public decimal Importe_Cheque_Cartera { get; set; }
        /// <summary>
        /// Algunos detalles sobre este cheque
        /// </summary>
        public string Detalle_Cheque_Cartera { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Localidad, Ciudades del sistema
        /// </summary>
        public Localidad Localidad { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla cheque_cartera.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Cheque_Cartera`, `Id_Localidad`, `Codigo_Cheque_Cartera`, `Numero_Recibo_Cheque_Cartera`, `Nombre_Cheque_Cartera`, `Fecha_Emicion_Cheque_Cartera`, `Fecha_Vencimiento_Cheque_Cartera`, `Nombre_Librador_Cheque_Cartera`, `Marca_Cheque_Cartera`, `Importe_Cheque_Cartera`, `Detalle_Cheque_Cartera` FROM cheque_cartera " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla cheque_cartera.
        /// </summary>
        /// <param name="Id_Cheque_Cartera">ID de la tabla</param>
        /// <param name="Id_Localidad">Localidad del cheque</param>
        /// <param name="Codigo_Cheque_Cartera">Numero, codigo del cheque</param>
        /// <param name="Numero_Recibo_Cheque_Cartera">Numero de recibo con el que entregaron el cheque</param>
        /// <param name="Nombre_Cheque_Cartera">Nombre del banco de donde sale el cheque</param>
        /// <param name="Fecha_Emicion_Cheque_Cartera">Fecha de cuando se emite el cheque</param>
        /// <param name="Fecha_Vencimiento_Cheque_Cartera">Cuando se vence</param>
        /// <param name="Nombre_Librador_Cheque_Cartera">Nombre del que libera el cheque</param>
        /// <param name="Marca_Cheque_Cartera"></param>
        /// <param name="Importe_Cheque_Cartera">Importe del cheque</param>
        /// <param name="Detalle_Cheque_Cartera">Algunos detalles sobre este cheque</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Cheque_Cartera, int Id_Localidad, string Codigo_Cheque_Cartera, int Numero_Recibo_Cheque_Cartera, string Nombre_Cheque_Cartera, DateTime Fecha_Emicion_Cheque_Cartera, DateTime Fecha_Vencimiento_Cheque_Cartera, string Nombre_Librador_Cheque_Cartera, bool Marca_Cheque_Cartera, decimal Importe_Cheque_Cartera, string Detalle_Cheque_Cartera)
        {
            return "INSERT INTO cheque_cartera(`Id_Cheque_Cartera`, `Id_Localidad`, `Codigo_Cheque_Cartera`, `Numero_Recibo_Cheque_Cartera`, `Nombre_Cheque_Cartera`, `Fecha_Emicion_Cheque_Cartera`, `Fecha_Vencimiento_Cheque_Cartera`, `Nombre_Librador_Cheque_Cartera`, `Marca_Cheque_Cartera`, `Importe_Cheque_Cartera`, `Detalle_Cheque_Cartera`) VALUES ('" + Id_Cheque_Cartera.ToString() + "', '" + Id_Localidad.ToString() + "', '" + Codigo_Cheque_Cartera.ToString() + "', '" + Numero_Recibo_Cheque_Cartera.ToString() + "', '" + Nombre_Cheque_Cartera.ToString() + "', '" + Fecha_Emicion_Cheque_Cartera.ToString() + "', '" + Fecha_Vencimiento_Cheque_Cartera.ToString() + "', '" + Nombre_Librador_Cheque_Cartera.ToString() + "', '" + Marca_Cheque_Cartera.ToString() + "', '" + Importe_Cheque_Cartera.ToString() + "', '" + Detalle_Cheque_Cartera.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla cheque_cartera.
        /// </summary>
        /// <param name="Id_Cheque_Cartera">ID de la tabla</param>
        /// <param name="Id_Localidad">Localidad del cheque</param>
        /// <param name="Codigo_Cheque_Cartera">Numero, codigo del cheque</param>
        /// <param name="Numero_Recibo_Cheque_Cartera">Numero de recibo con el que entregaron el cheque</param>
        /// <param name="Nombre_Cheque_Cartera">Nombre del banco de donde sale el cheque</param>
        /// <param name="Fecha_Emicion_Cheque_Cartera">Fecha de cuando se emite el cheque</param>
        /// <param name="Fecha_Vencimiento_Cheque_Cartera">Cuando se vence</param>
        /// <param name="Nombre_Librador_Cheque_Cartera">Nombre del que libera el cheque</param>
        /// <param name="Marca_Cheque_Cartera"></param>
        /// <param name="Importe_Cheque_Cartera">Importe del cheque</param>
        /// <param name="Detalle_Cheque_Cartera">Algunos detalles sobre este cheque</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Cheque_Cartera, int Id_Localidad, string Codigo_Cheque_Cartera, int Numero_Recibo_Cheque_Cartera, string Nombre_Cheque_Cartera, DateTime Fecha_Emicion_Cheque_Cartera, DateTime Fecha_Vencimiento_Cheque_Cartera, string Nombre_Librador_Cheque_Cartera, bool Marca_Cheque_Cartera, decimal Importe_Cheque_Cartera, string Detalle_Cheque_Cartera, string Filtro)
        {
            return "UPDATE cheque_cartera SET `Id_Cheque_Cartera` = '" + Id_Cheque_Cartera.ToString() + "', `Id_Localidad` = '" + Id_Localidad.ToString() + "', `Codigo_Cheque_Cartera` = '" + Codigo_Cheque_Cartera.ToString() + "', `Numero_Recibo_Cheque_Cartera` = '" + Numero_Recibo_Cheque_Cartera.ToString() + "', `Nombre_Cheque_Cartera` = '" + Nombre_Cheque_Cartera.ToString() + "', `Fecha_Emicion_Cheque_Cartera` = '" + Fecha_Emicion_Cheque_Cartera.ToString() + "', `Fecha_Vencimiento_Cheque_Cartera` = '" + Fecha_Vencimiento_Cheque_Cartera.ToString() + "', `Nombre_Librador_Cheque_Cartera` = '" + Nombre_Librador_Cheque_Cartera.ToString() + "', `Marca_Cheque_Cartera` = '" + Marca_Cheque_Cartera.ToString() + "', `Importe_Cheque_Cartera` = '" + Importe_Cheque_Cartera.ToString() + "', `Detalle_Cheque_Cartera` = '" + Detalle_Cheque_Cartera.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Cheque_cartera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Cheque_cartera</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Cheque_cartera Obj)
        {
            if (Obj.Codigo_Cheque_Cartera == null)
            {
                throw new Exception("Codigo_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Emicion_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Emicion_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Vencimiento_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Librador_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Librador_Cheque_Cartera no puede ser null");
            }
            if (Obj.Detalle_Cheque_Cartera == null)
            {
                throw new Exception("Detalle_Cheque_Cartera no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO cheque_cartera(`Id_Localidad`, `Codigo_Cheque_Cartera`, `Numero_Recibo_Cheque_Cartera`, `Nombre_Cheque_Cartera`, `Fecha_Emicion_Cheque_Cartera`, `Fecha_Vencimiento_Cheque_Cartera`, `Nombre_Librador_Cheque_Cartera`, `Marca_Cheque_Cartera`, `Importe_Cheque_Cartera`, `Detalle_Cheque_Cartera`)VALUES( " + "'" + Obj.Id_Localidad.ToString() + "', " + "'" + Obj.Codigo_Cheque_Cartera + "', " + "'" + Obj.Numero_Recibo_Cheque_Cartera.ToString() + "', " + "'" + Obj.Nombre_Cheque_Cartera + "', " + "'" + Obj.Fecha_Emicion_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Vencimiento_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Nombre_Librador_Cheque_Cartera + "', " + Common.BoolToString(Obj.Marca_Cheque_Cartera) + ", " + "'" + Obj.Importe_Cheque_Cartera.ToString().Replace(",", ".") + "', " + "'" + Obj.Detalle_Cheque_Cartera + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Cheque_cartera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Cheque_cartera</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Cheque_cartera Obj)
        {
            if (Obj.Codigo_Cheque_Cartera == null)
            {
                throw new Exception("Codigo_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Emicion_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Emicion_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Vencimiento_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Librador_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Librador_Cheque_Cartera no puede ser null");
            }
            if (Obj.Detalle_Cheque_Cartera == null)
            {
                throw new Exception("Detalle_Cheque_Cartera no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE cheque_cartera SET `Id_Localidad` =  '" + Obj.Id_Localidad.ToString() + "', `Codigo_Cheque_Cartera` =  '" + Obj.Codigo_Cheque_Cartera + "', `Numero_Recibo_Cheque_Cartera` =  '" + Obj.Numero_Recibo_Cheque_Cartera.ToString() + "', `Nombre_Cheque_Cartera` =  '" + Obj.Nombre_Cheque_Cartera + "', `Fecha_Emicion_Cheque_Cartera` =  '" + Obj.Fecha_Emicion_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Vencimiento_Cheque_Cartera` =  '" + Obj.Fecha_Vencimiento_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', `Nombre_Librador_Cheque_Cartera` =  '" + Obj.Nombre_Librador_Cheque_Cartera + "', `Marca_Cheque_Cartera` = " + Common.BoolToString(Obj.Marca_Cheque_Cartera) + ", `Importe_Cheque_Cartera` =  '" + Obj.Importe_Cheque_Cartera.ToString().Replace(",", ".") + "', `Detalle_Cheque_Cartera` =  '" + Obj.Detalle_Cheque_Cartera + "' WHERE cheque_cartera.Id_Cheque_Cartera = " + Obj.Id_Cheque_Cartera.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Cheque_cartera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM cheque_cartera WHERE cheque_cartera.Id_Cheque_Cartera = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Cheque_cartera. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Cheque_cartera</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Cheque_cartera Obj)
        {
            if (Obj.Codigo_Cheque_Cartera == null)
            {
                throw new Exception("Codigo_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Emicion_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Emicion_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Vencimiento_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Librador_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Librador_Cheque_Cartera no puede ser null");
            }
            if (Obj.Detalle_Cheque_Cartera == null)
            {
                throw new Exception("Detalle_Cheque_Cartera no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO cheque_cartera(`Id_Localidad`, `Codigo_Cheque_Cartera`, `Numero_Recibo_Cheque_Cartera`, `Nombre_Cheque_Cartera`, `Fecha_Emicion_Cheque_Cartera`, `Fecha_Vencimiento_Cheque_Cartera`, `Nombre_Librador_Cheque_Cartera`, `Marca_Cheque_Cartera`, `Importe_Cheque_Cartera`, `Detalle_Cheque_Cartera`)VALUES( " + "'" + Obj.Id_Localidad.ToString() + "', " + "'" + Obj.Codigo_Cheque_Cartera + "', " + "'" + Obj.Numero_Recibo_Cheque_Cartera.ToString() + "', " + "'" + Obj.Nombre_Cheque_Cartera + "', " + "'" + Obj.Fecha_Emicion_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Vencimiento_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Nombre_Librador_Cheque_Cartera + "', " + Common.BoolToString(Obj.Marca_Cheque_Cartera) + ", " + "'" + Obj.Importe_Cheque_Cartera.ToString().Replace(",", ".") + "', " + "'" + Obj.Detalle_Cheque_Cartera + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Cheque_cartera. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Cheque_cartera</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Cheque_cartera Obj)
        {
            if (Obj.Codigo_Cheque_Cartera == null)
            {
                throw new Exception("Codigo_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Emicion_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Emicion_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Vencimiento_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Librador_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Librador_Cheque_Cartera no puede ser null");
            }
            if (Obj.Detalle_Cheque_Cartera == null)
            {
                throw new Exception("Detalle_Cheque_Cartera no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE cheque_cartera SET `Id_Localidad` =  '" + Obj.Id_Localidad.ToString() + "', `Codigo_Cheque_Cartera` =  '" + Obj.Codigo_Cheque_Cartera + "', `Numero_Recibo_Cheque_Cartera` =  '" + Obj.Numero_Recibo_Cheque_Cartera.ToString() + "', `Nombre_Cheque_Cartera` =  '" + Obj.Nombre_Cheque_Cartera + "', `Fecha_Emicion_Cheque_Cartera` =  '" + Obj.Fecha_Emicion_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Vencimiento_Cheque_Cartera` =  '" + Obj.Fecha_Vencimiento_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', `Nombre_Librador_Cheque_Cartera` =  '" + Obj.Nombre_Librador_Cheque_Cartera + "', `Marca_Cheque_Cartera` = " + Common.BoolToString(Obj.Marca_Cheque_Cartera) + ", `Importe_Cheque_Cartera` =  '" + Obj.Importe_Cheque_Cartera.ToString().Replace(",", ".") + "', `Detalle_Cheque_Cartera` =  '" + Obj.Detalle_Cheque_Cartera + "' WHERE cheque_cartera.Id_Cheque_Cartera = " + Obj.Id_Cheque_Cartera.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Cheque_cartera. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM cheque_cartera WHERE cheque_cartera.Id_Cheque_Cartera = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Se lleva el control de las coutas
    /// La última modificación fué el miércoles, 23 de noviembre de 2011 a las 11:33:12 a.m.
    /// </summary>
    public partial class Couta
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Couta()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Couta</param>
        public Couta(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Couta"))
            {
                if (DataRowConstructor["Id_Couta"] != DBNull.Value)
                {
                    this.Id_Couta = Convert.ToInt32(DataRowConstructor["Id_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura"))
            {
                if (DataRowConstructor["Id_Factura"] != DBNull.Value)
                {
                    this.Id_Factura = Convert.ToInt32(DataRowConstructor["Id_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Couta_Couta"))
            {
                if (DataRowConstructor["Numero_Couta_Couta"] != DBNull.Value)
                {
                    this.Numero_Couta_Couta = Convert.ToInt32(DataRowConstructor["Numero_Couta_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Vencimineto_Couta"))
            {
                if (DataRowConstructor["Fecha_Vencimineto_Couta"] != DBNull.Value)
                {
                    this.Fecha_Vencimineto_Couta = Convert.ToDateTime(DataRowConstructor["Fecha_Vencimineto_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Pago_Couta"))
            {
                if (DataRowConstructor["Fecha_Pago_Couta"] != DBNull.Value)
                {
                    this.Fecha_Pago_Couta = Convert.ToDateTime(DataRowConstructor["Fecha_Pago_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Couta"))
            {
                if (DataRowConstructor["Importe_Couta"] != DBNull.Value)
                {
                    this.Importe_Couta = Convert.ToDecimal(DataRowConstructor["Importe_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Interes_Couta"))
            {
                if (DataRowConstructor["Importe_Interes_Couta"] != DBNull.Value)
                {
                    this.Importe_Interes_Couta = Convert.ToDecimal(DataRowConstructor["Importe_Interes_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Asignacion_Cuota"))
            {
                if (DataRowConstructor["Asignacion_Cuota"] != DBNull.Value)
                {
                    this.Asignacion_Cuota = Convert.ToDecimal(DataRowConstructor["Asignacion_Cuota"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Pagado_Couta"))
            {
                if (DataRowConstructor["Pagado_Couta"] != DBNull.Value)
                {
                    this.Pagado_Couta = Convert.ToBoolean(DataRowConstructor["Pagado_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Couta"))
            {
                if (DataRowConstructor["Observaciones_Couta"] != DBNull.Value)
                {
                    this.Observaciones_Couta = DataRowConstructor["Observaciones_Couta"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Couta</param>
        public Couta(DataSet DataSetConstructor)
        {
            this.ListaCouta = new List<Couta>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Couta TEMP = new Couta(Fila);
                TEMP.Factura = new Factura(Fila);
                this.ListaCouta.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Couta> ListaCouta { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Couta { get; set; }
        /// <summary>
        /// ID de la factura
        /// </summary>
        public int Id_Factura { get; set; }
        /// <summary>
        /// Numero de la cuota
        /// </summary>
        public int Numero_Couta_Couta { get; set; }
        /// <summary>
        /// Fecha vencimiento
        /// </summary>
        public DateTime Fecha_Vencimineto_Couta { get; set; }
        /// <summary>
        /// Fecha del pago de la cuota
        /// </summary>
        public DateTime Fecha_Pago_Couta { get; set; }
        /// <summary>
        /// Importe de la cuota
        /// </summary>
        public decimal Importe_Couta { get; set; }
        /// <summary>
        /// Este interes se agrecuando se pago fuera de termino
        /// </summary>
        public decimal Importe_Interes_Couta { get; set; }
        /// <summary>
        /// Aca se guarda el valor que se le va a asignar a la cuota, esto sirve para pargar una cuota parcialmente (fecha modif.: 23-11-2011)
        /// </summary>
        public decimal Asignacion_Cuota { get; set; }
        /// <summary>
        /// Este campo es vendadero cuando esta cuota ya esta pagada
        /// </summary>
        public bool Pagado_Couta { get; set; }
        /// <summary>
        /// Algunas observaciones en el pago de la cuota
        /// </summary>
        public string Observaciones_Couta { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura, Aca van todas las facturas
        /// </summary>
        public Factura Factura { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla couta.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Couta`, `Id_Factura`, `Numero_Couta_Couta`, `Fecha_Vencimineto_Couta`, `Fecha_Pago_Couta`, `Importe_Couta`, `Importe_Interes_Couta`, `Asignacion_Cuota`, `Pagado_Couta`, `Observaciones_Couta` FROM couta " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla couta.
        /// </summary>
        /// <param name="Id_Couta">ID de la tabla</param>
        /// <param name="Id_Factura">ID de la factura</param>
        /// <param name="Numero_Couta_Couta">Numero de la cuota</param>
        /// <param name="Fecha_Vencimineto_Couta">Fecha vencimiento</param>
        /// <param name="Fecha_Pago_Couta">Fecha del pago de la cuota</param>
        /// <param name="Importe_Couta">Importe de la cuota</param>
        /// <param name="Importe_Interes_Couta">Este interes se agrecuando se pago fuera de termino</param>
        /// <param name="Asignacion_Cuota">Aca se guarda el valor que se le va a asignar a la cuota, esto sirve para pargar una cuota parcialmente (fecha modif.: 23-11-2011)</param>
        /// <param name="Pagado_Couta">Este campo es vendadero cuando esta cuota ya esta pagada</param>
        /// <param name="Observaciones_Couta">Algunas observaciones en el pago de la cuota</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Couta, int Id_Factura, int Numero_Couta_Couta, DateTime Fecha_Vencimineto_Couta, DateTime Fecha_Pago_Couta, decimal Importe_Couta, decimal Importe_Interes_Couta, decimal Asignacion_Cuota, bool Pagado_Couta, string Observaciones_Couta)
        {
            return "INSERT INTO couta(`Id_Couta`, `Id_Factura`, `Numero_Couta_Couta`, `Fecha_Vencimineto_Couta`, `Fecha_Pago_Couta`, `Importe_Couta`, `Importe_Interes_Couta`, `Asignacion_Cuota`, `Pagado_Couta`, `Observaciones_Couta`) VALUES ('" + Id_Couta.ToString() + "', '" + Id_Factura.ToString() + "', '" + Numero_Couta_Couta.ToString() + "', '" + Fecha_Vencimineto_Couta.ToString() + "', '" + Fecha_Pago_Couta.ToString() + "', '" + Importe_Couta.ToString() + "', '" + Importe_Interes_Couta.ToString() + "', '" + Asignacion_Cuota.ToString() + "', '" + Pagado_Couta.ToString() + "', '" + Observaciones_Couta.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla couta.
        /// </summary>
        /// <param name="Id_Couta">ID de la tabla</param>
        /// <param name="Id_Factura">ID de la factura</param>
        /// <param name="Numero_Couta_Couta">Numero de la cuota</param>
        /// <param name="Fecha_Vencimineto_Couta">Fecha vencimiento</param>
        /// <param name="Fecha_Pago_Couta">Fecha del pago de la cuota</param>
        /// <param name="Importe_Couta">Importe de la cuota</param>
        /// <param name="Importe_Interes_Couta">Este interes se agrecuando se pago fuera de termino</param>
        /// <param name="Asignacion_Cuota">Aca se guarda el valor que se le va a asignar a la cuota, esto sirve para pargar una cuota parcialmente (fecha modif.: 23-11-2011)</param>
        /// <param name="Pagado_Couta">Este campo es vendadero cuando esta cuota ya esta pagada</param>
        /// <param name="Observaciones_Couta">Algunas observaciones en el pago de la cuota</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Couta, int Id_Factura, int Numero_Couta_Couta, DateTime Fecha_Vencimineto_Couta, DateTime Fecha_Pago_Couta, decimal Importe_Couta, decimal Importe_Interes_Couta, decimal Asignacion_Cuota, bool Pagado_Couta, string Observaciones_Couta, string Filtro)
        {
            return "UPDATE couta SET `Id_Couta` = '" + Id_Couta.ToString() + "', `Id_Factura` = '" + Id_Factura.ToString() + "', `Numero_Couta_Couta` = '" + Numero_Couta_Couta.ToString() + "', `Fecha_Vencimineto_Couta` = '" + Fecha_Vencimineto_Couta.ToString() + "', `Fecha_Pago_Couta` = '" + Fecha_Pago_Couta.ToString() + "', `Importe_Couta` = '" + Importe_Couta.ToString() + "', `Importe_Interes_Couta` = '" + Importe_Interes_Couta.ToString() + "', `Asignacion_Cuota` = '" + Asignacion_Cuota.ToString() + "', `Pagado_Couta` = '" + Pagado_Couta.ToString() + "', `Observaciones_Couta` = '" + Observaciones_Couta.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Couta.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Couta</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Couta Obj)
        {
            if (Obj.Fecha_Vencimineto_Couta == null)
            {
                throw new Exception("Fecha_Vencimineto_Couta no puede ser null");
            }
            if (Obj.Fecha_Pago_Couta == null)
            {
                throw new Exception("Fecha_Pago_Couta no puede ser null");
            }
            if (Obj.Observaciones_Couta == null)
            {
                throw new Exception("Observaciones_Couta no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO couta(`Id_Factura`, `Numero_Couta_Couta`, `Fecha_Vencimineto_Couta`, `Fecha_Pago_Couta`, `Importe_Couta`, `Importe_Interes_Couta`, `Asignacion_Cuota`, `Pagado_Couta`, `Observaciones_Couta`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Numero_Couta_Couta.ToString() + "', " + "'" + Obj.Fecha_Vencimineto_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Pago_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Importe_Couta.ToString().Replace(",", ".") + "', " + "'" + Obj.Importe_Interes_Couta.ToString().Replace(",", ".") + "', " + "'" + Obj.Asignacion_Cuota.ToString().Replace(",", ".") + "', " + Common.BoolToString(Obj.Pagado_Couta) + ", " + "'" + Obj.Observaciones_Couta + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Couta.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Couta</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Couta Obj)
        {
            if (Obj.Fecha_Vencimineto_Couta == null)
            {
                throw new Exception("Fecha_Vencimineto_Couta no puede ser null");
            }
            if (Obj.Fecha_Pago_Couta == null)
            {
                throw new Exception("Fecha_Pago_Couta no puede ser null");
            }
            if (Obj.Observaciones_Couta == null)
            {
                throw new Exception("Observaciones_Couta no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE couta SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Numero_Couta_Couta` =  '" + Obj.Numero_Couta_Couta.ToString() + "', `Fecha_Vencimineto_Couta` =  '" + Obj.Fecha_Vencimineto_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Pago_Couta` =  '" + Obj.Fecha_Pago_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', `Importe_Couta` =  '" + Obj.Importe_Couta.ToString().Replace(",", ".") + "', `Importe_Interes_Couta` =  '" + Obj.Importe_Interes_Couta.ToString().Replace(",", ".") + "', `Asignacion_Cuota` =  '" + Obj.Asignacion_Cuota.ToString().Replace(",", ".") + "', `Pagado_Couta` = " + Common.BoolToString(Obj.Pagado_Couta) + ", `Observaciones_Couta` =  '" + Obj.Observaciones_Couta + "' WHERE couta.Id_Couta = " + Obj.Id_Couta.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Couta.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM couta WHERE couta.Id_Couta = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Couta. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Couta</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Couta Obj)
        {
            if (Obj.Fecha_Vencimineto_Couta == null)
            {
                throw new Exception("Fecha_Vencimineto_Couta no puede ser null");
            }
            if (Obj.Fecha_Pago_Couta == null)
            {
                throw new Exception("Fecha_Pago_Couta no puede ser null");
            }
            if (Obj.Observaciones_Couta == null)
            {
                throw new Exception("Observaciones_Couta no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO couta(`Id_Factura`, `Numero_Couta_Couta`, `Fecha_Vencimineto_Couta`, `Fecha_Pago_Couta`, `Importe_Couta`, `Importe_Interes_Couta`, `Asignacion_Cuota`, `Pagado_Couta`, `Observaciones_Couta`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Numero_Couta_Couta.ToString() + "', " + "'" + Obj.Fecha_Vencimineto_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Pago_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Importe_Couta.ToString().Replace(",", ".") + "', " + "'" + Obj.Importe_Interes_Couta.ToString().Replace(",", ".") + "', " + "'" + Obj.Asignacion_Cuota.ToString().Replace(",", ".") + "', " + Common.BoolToString(Obj.Pagado_Couta) + ", " + "'" + Obj.Observaciones_Couta + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Couta. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Couta</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Couta Obj)
        {
            if (Obj.Fecha_Vencimineto_Couta == null)
            {
                throw new Exception("Fecha_Vencimineto_Couta no puede ser null");
            }
            if (Obj.Fecha_Pago_Couta == null)
            {
                throw new Exception("Fecha_Pago_Couta no puede ser null");
            }
            if (Obj.Observaciones_Couta == null)
            {
                throw new Exception("Observaciones_Couta no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE couta SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Numero_Couta_Couta` =  '" + Obj.Numero_Couta_Couta.ToString() + "', `Fecha_Vencimineto_Couta` =  '" + Obj.Fecha_Vencimineto_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Pago_Couta` =  '" + Obj.Fecha_Pago_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', `Importe_Couta` =  '" + Obj.Importe_Couta.ToString().Replace(",", ".") + "', `Importe_Interes_Couta` =  '" + Obj.Importe_Interes_Couta.ToString().Replace(",", ".") + "', `Asignacion_Cuota` =  '" + Obj.Asignacion_Cuota.ToString().Replace(",", ".") + "', `Pagado_Couta` = " + Common.BoolToString(Obj.Pagado_Couta) + ", `Observaciones_Couta` =  '" + Obj.Observaciones_Couta + "' WHERE couta.Id_Couta = " + Obj.Id_Couta.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Couta. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM couta WHERE couta.Id_Couta = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Todas las entrega de documentacion de automotores
    /// La última modificación fué el martes, 24 de enero de 2012 a las 06:00:11 p.m.
    /// </summary>
    public partial class Documento
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Documento()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Documento</param>
        public Documento(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Documento"))
            {
                if (DataRowConstructor["Id_Documento"] != DBNull.Value)
                {
                    this.Id_Documento = Convert.ToInt32(DataRowConstructor["Id_Documento"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura"))
            {
                if (DataRowConstructor["Id_Factura"] != DBNull.Value)
                {
                    this.Id_Factura = Convert.ToInt32(DataRowConstructor["Id_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Entrega_Documento"))
            {
                if (DataRowConstructor["Fecha_Entrega_Documento"] != DBNull.Value)
                {
                    this.Fecha_Entrega_Documento = Convert.ToDateTime(DataRowConstructor["Fecha_Entrega_Documento"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Dominio_Documento"))
            {
                if (DataRowConstructor["Dominio_Documento"] != DBNull.Value)
                {
                    this.Dominio_Documento = DataRowConstructor["Dominio_Documento"].ToString().Replace("{COMISIMPLE}", "'").Replace("{COMIDOBLE}", "\"");
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Documento"))
            {
                if (DataRowConstructor["Observaciones_Documento"] != DBNull.Value)
                {
                    this.Observaciones_Documento = DataRowConstructor["Observaciones_Documento"].ToString().Replace("{COMISIMPLE}", "'").Replace("{COMIDOBLE}", "\"");
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Documento</param>
        public Documento(DataSet DataSetConstructor)
        {
            this.ListaDocumento = new List<Documento>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Documento TEMP = new Documento(Fila);
                TEMP.Factura = new Factura(Fila);
                this.ListaDocumento.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Documento> ListaDocumento { get; set; }
        /// <summary>
        /// Numero de documento de entrega
        /// </summary>
        public int Id_Documento { get; set; }
        /// <summary>
        /// Factura relacionada a la entrega de documentacion
        /// </summary>
        public int Id_Factura { get; set; }
        /// <summary>
        /// Fecha de entrega de documentacion
        /// </summary>
        public DateTime Fecha_Entrega_Documento { get; set; }
        /// <summary>
        /// Numero de patente, se pone aca porque se sabe cuando se entrega la documentacion
        /// </summary>
        public string Dominio_Documento { get; set; }
        /// <summary>
        /// Algunas observaciones en la entrega de la documentacion
        /// </summary>
        public string Observaciones_Documento { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura, Aca van todas las facturas
        /// </summary>
        public Factura Factura { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla documento.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Documento`, `Id_Factura`, `Fecha_Entrega_Documento`, `Dominio_Documento`, `Observaciones_Documento` FROM documento " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla documento.
        /// </summary>
        /// <param name="Id_Documento">Numero de documento de entrega</param>
        /// <param name="Id_Factura">Factura relacionada a la entrega de documentacion</param>
        /// <param name="Fecha_Entrega_Documento">Fecha de entrega de documentacion</param>
        /// <param name="Dominio_Documento">Numero de patente, se pone aca porque se sabe cuando se entrega la documentacion</param>
        /// <param name="Observaciones_Documento">Algunas observaciones en la entrega de la documentacion</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Documento, int Id_Factura, DateTime Fecha_Entrega_Documento, string Dominio_Documento, string Observaciones_Documento)
        {
            return "INSERT INTO documento(`Id_Documento`, `Id_Factura`, `Fecha_Entrega_Documento`, `Dominio_Documento`, `Observaciones_Documento`) VALUES ('" + Id_Documento.ToString() + "', '" + Id_Factura.ToString() + "', '" + Fecha_Entrega_Documento.ToString() + "', '" + Dominio_Documento.ToString() + "', '" + Observaciones_Documento.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla documento.
        /// </summary>
        /// <param name="Id_Documento">Numero de documento de entrega</param>
        /// <param name="Id_Factura">Factura relacionada a la entrega de documentacion</param>
        /// <param name="Fecha_Entrega_Documento">Fecha de entrega de documentacion</param>
        /// <param name="Dominio_Documento">Numero de patente, se pone aca porque se sabe cuando se entrega la documentacion</param>
        /// <param name="Observaciones_Documento">Algunas observaciones en la entrega de la documentacion</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Documento, int Id_Factura, DateTime Fecha_Entrega_Documento, string Dominio_Documento, string Observaciones_Documento, string Filtro)
        {
            return "UPDATE documento SET `Id_Documento` = '" + Id_Documento.ToString() + "', `Id_Factura` = '" + Id_Factura.ToString() + "', `Fecha_Entrega_Documento` = '" + Fecha_Entrega_Documento.ToString() + "', `Dominio_Documento` = '" + Dominio_Documento.ToString() + "', `Observaciones_Documento` = '" + Observaciones_Documento.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Documento.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Documento</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Documento Obj)
        {
            if (Obj.Fecha_Entrega_Documento == null)
            {
                throw new Exception("Fecha_Entrega_Documento no puede ser null");
            }
            if (Obj.Dominio_Documento == null)
            {
                throw new Exception("Dominio_Documento no puede ser null");
            }
            if (Obj.Observaciones_Documento == null)
            {
                throw new Exception("Observaciones_Documento no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO documento(`Id_Factura`, `Fecha_Entrega_Documento`, `Dominio_Documento`, `Observaciones_Documento`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Fecha_Entrega_Documento.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Dominio_Documento.Replace("'", "{COMISIMPLE}").Replace("\"", "{COMIDOBLE}") + "', " + "'" + Obj.Observaciones_Documento.Replace("'", "{COMISIMPLE}").Replace("\"", "{COMIDOBLE}") + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Documento.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Documento</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Documento Obj)
        {
            if (Obj.Fecha_Entrega_Documento == null)
            {
                throw new Exception("Fecha_Entrega_Documento no puede ser null");
            }
            if (Obj.Dominio_Documento == null)
            {
                throw new Exception("Dominio_Documento no puede ser null");
            }
            if (Obj.Observaciones_Documento == null)
            {
                throw new Exception("Observaciones_Documento no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE documento SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Fecha_Entrega_Documento` =  '" + Obj.Fecha_Entrega_Documento.ToString("yyyy-MM-dd HH:mm:ss") + "', `Dominio_Documento` =  '" + Obj.Dominio_Documento.Replace("'", "{COMISIMPLE}").Replace("\"", "{COMIDOBLE}") + "', `Observaciones_Documento` =  '" + Obj.Observaciones_Documento.Replace("'", "{COMISIMPLE}").Replace("\"", "{COMIDOBLE}") + "' WHERE documento.Id_Documento = " + Obj.Id_Documento.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Documento.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM documento WHERE documento.Id_Documento = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Documento. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Documento</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Documento Obj)
        {
            if (Obj.Fecha_Entrega_Documento == null)
            {
                throw new Exception("Fecha_Entrega_Documento no puede ser null");
            }
            if (Obj.Dominio_Documento == null)
            {
                throw new Exception("Dominio_Documento no puede ser null");
            }
            if (Obj.Observaciones_Documento == null)
            {
                throw new Exception("Observaciones_Documento no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO documento(`Id_Factura`, `Fecha_Entrega_Documento`, `Dominio_Documento`, `Observaciones_Documento`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Fecha_Entrega_Documento.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Dominio_Documento.Replace("'", "{COMISIMPLE}").Replace("\"", "{COMIDOBLE}") + "', " + "'" + Obj.Observaciones_Documento.Replace("'", "{COMISIMPLE}").Replace("\"", "{COMIDOBLE}") + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Documento. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Documento</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Documento Obj)
        {
            if (Obj.Fecha_Entrega_Documento == null)
            {
                throw new Exception("Fecha_Entrega_Documento no puede ser null");
            }
            if (Obj.Dominio_Documento == null)
            {
                throw new Exception("Dominio_Documento no puede ser null");
            }
            if (Obj.Observaciones_Documento == null)
            {
                throw new Exception("Observaciones_Documento no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE documento SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Fecha_Entrega_Documento` =  '" + Obj.Fecha_Entrega_Documento.ToString("yyyy-MM-dd HH:mm:ss") + "', `Dominio_Documento` =  '" + Obj.Dominio_Documento.Replace("'", "{COMISIMPLE}").Replace("\"", "{COMIDOBLE}") + "', `Observaciones_Documento` =  '" + Obj.Observaciones_Documento.Replace("'", "{COMISIMPLE}").Replace("\"", "{COMIDOBLE}") + "' WHERE documento.Id_Documento = " + Obj.Id_Documento.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Documento. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM documento WHERE documento.Id_Documento = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Datos de la empresa
    /// La última modificación fué el miércoles, 12 de octubre de 2011 a las 05:32:10 p.m.
    /// </summary>
    public partial class Empresa
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Empresa()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Empresa</param>
        public Empresa(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Empresa"))
            {
                if (DataRowConstructor["Id_Empresa"] != DBNull.Value)
                {
                    this.Id_Empresa = Convert.ToInt32(DataRowConstructor["Id_Empresa"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Localidad"))
            {
                if (DataRowConstructor["Id_Localidad"] != DBNull.Value)
                {
                    this.Id_Localidad = Convert.ToInt32(DataRowConstructor["Id_Localidad"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero_IVA"))
            {
                if (DataRowConstructor["Id_Tercero_IVA"] != DBNull.Value)
                {
                    this.Id_Tercero_IVA = Convert.ToInt32(DataRowConstructor["Id_Tercero_IVA"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Razon_Social_Empresa"))
            {
                if (DataRowConstructor["Razon_Social_Empresa"] != DBNull.Value)
                {
                    this.Razon_Social_Empresa = DataRowConstructor["Razon_Social_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Titular_Empresa"))
            {
                if (DataRowConstructor["Titular_Empresa"] != DBNull.Value)
                {
                    this.Titular_Empresa = DataRowConstructor["Titular_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("CUIT_Empresa"))
            {
                if (DataRowConstructor["CUIT_Empresa"] != DBNull.Value)
                {
                    this.CUIT_Empresa = DataRowConstructor["CUIT_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Direccion_Empresa"))
            {
                if (DataRowConstructor["Direccion_Empresa"] != DBNull.Value)
                {
                    this.Direccion_Empresa = DataRowConstructor["Direccion_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Telefonos_Empresa"))
            {
                if (DataRowConstructor["Telefonos_Empresa"] != DBNull.Value)
                {
                    this.Telefonos_Empresa = DataRowConstructor["Telefonos_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fax_Empresa"))
            {
                if (DataRowConstructor["Fax_Empresa"] != DBNull.Value)
                {
                    this.Fax_Empresa = DataRowConstructor["Fax_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Email_Empresa"))
            {
                if (DataRowConstructor["Email_Empresa"] != DBNull.Value)
                {
                    this.Email_Empresa = DataRowConstructor["Email_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Web_Empresa"))
            {
                if (DataRowConstructor["Web_Empresa"] != DBNull.Value)
                {
                    this.Web_Empresa = DataRowConstructor["Web_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Inicio_Actividades_Empresa"))
            {
                if (DataRowConstructor["Inicio_Actividades_Empresa"] != DBNull.Value)
                {
                    this.Inicio_Actividades_Empresa = Convert.ToDateTime(DataRowConstructor["Inicio_Actividades_Empresa"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Ingresos_Brutos_Empresa"))
            {
                if (DataRowConstructor["Ingresos_Brutos_Empresa"] != DBNull.Value)
                {
                    this.Ingresos_Brutos_Empresa = DataRowConstructor["Ingresos_Brutos_Empresa"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Empresa</param>
        public Empresa(DataSet DataSetConstructor)
        {
            this.ListaEmpresa = new List<Empresa>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Empresa TEMP = new Empresa(Fila);
                TEMP.Localidad = new Localidad(Fila);
                TEMP.Tercero_iva = new Tercero_iva(Fila);
                this.ListaEmpresa.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Empresa> ListaEmpresa { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Empresa { get; set; }
        /// <summary>
        /// Localidad de la empresa
        /// </summary>
        public int Id_Localidad { get; set; }
        /// <summary>
        /// IVA de la empresa
        /// </summary>
        public int Id_Tercero_IVA { get; set; }
        /// <summary>
        /// Razon Social o nombre de la empresa
        /// </summary>
        public string Razon_Social_Empresa { get; set; }
        /// <summary>
        /// Titular de dueño de la empresa
        /// </summary>
        public string Titular_Empresa { get; set; }
        /// <summary>
        /// CUIT de la empresa
        /// </summary>
        public string CUIT_Empresa { get; set; }
        /// <summary>
        /// Direccion de la empresa
        /// </summary>
        public string Direccion_Empresa { get; set; }
        /// <summary>
        /// Telefonos de la empresa
        /// </summary>
        public string Telefonos_Empresa { get; set; }
        /// <summary>
        /// Fax de la empresa
        /// </summary>
        public string Fax_Empresa { get; set; }
        /// <summary>
        /// Email de la empresa
        /// </summary>
        public string Email_Empresa { get; set; }
        /// <summary>
        /// Web de la empresa
        /// </summary>
        public string Web_Empresa { get; set; }
        /// <summary>
        /// Cuando se inicio la actividad de la empresa
        /// </summary>
        public DateTime Inicio_Actividades_Empresa { get; set; }
        /// <summary>
        /// Ingresos brutos de la empresa
        /// </summary>
        public string Ingresos_Brutos_Empresa { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Localidad, Ciudades del sistema
        /// </summary>
        public Localidad Localidad { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero_iva, Tipo de condicion de IVA
        /// </summary>
        public Tercero_iva Tercero_iva { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla empresa.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Empresa`, `Id_Localidad`, `Id_Tercero_IVA`, `Razon_Social_Empresa`, `Titular_Empresa`, `CUIT_Empresa`, `Direccion_Empresa`, `Telefonos_Empresa`, `Fax_Empresa`, `Email_Empresa`, `Web_Empresa`, `Inicio_Actividades_Empresa`, `Ingresos_Brutos_Empresa` FROM empresa " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla empresa.
        /// </summary>
        /// <param name="Id_Empresa">ID de la tabla</param>
        /// <param name="Id_Localidad">Localidad de la empresa</param>
        /// <param name="Id_Tercero_IVA">IVA de la empresa</param>
        /// <param name="Razon_Social_Empresa">Razon Social o nombre de la empresa</param>
        /// <param name="Titular_Empresa">Titular de dueño de la empresa</param>
        /// <param name="CUIT_Empresa">CUIT de la empresa</param>
        /// <param name="Direccion_Empresa">Direccion de la empresa</param>
        /// <param name="Telefonos_Empresa">Telefonos de la empresa</param>
        /// <param name="Fax_Empresa">Fax de la empresa</param>
        /// <param name="Email_Empresa">Email de la empresa</param>
        /// <param name="Web_Empresa">Web de la empresa</param>
        /// <param name="Inicio_Actividades_Empresa">Cuando se inicio la actividad de la empresa</param>
        /// <param name="Ingresos_Brutos_Empresa">Ingresos brutos de la empresa</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Empresa, int Id_Localidad, int Id_Tercero_IVA, string Razon_Social_Empresa, string Titular_Empresa, string CUIT_Empresa, string Direccion_Empresa, string Telefonos_Empresa, string Fax_Empresa, string Email_Empresa, string Web_Empresa, DateTime Inicio_Actividades_Empresa, string Ingresos_Brutos_Empresa)
        {
            return "INSERT INTO empresa(`Id_Empresa`, `Id_Localidad`, `Id_Tercero_IVA`, `Razon_Social_Empresa`, `Titular_Empresa`, `CUIT_Empresa`, `Direccion_Empresa`, `Telefonos_Empresa`, `Fax_Empresa`, `Email_Empresa`, `Web_Empresa`, `Inicio_Actividades_Empresa`, `Ingresos_Brutos_Empresa`) VALUES ('" + Id_Empresa.ToString() + "', '" + Id_Localidad.ToString() + "', '" + Id_Tercero_IVA.ToString() + "', '" + Razon_Social_Empresa.ToString() + "', '" + Titular_Empresa.ToString() + "', '" + CUIT_Empresa.ToString() + "', '" + Direccion_Empresa.ToString() + "', '" + Telefonos_Empresa.ToString() + "', '" + Fax_Empresa.ToString() + "', '" + Email_Empresa.ToString() + "', '" + Web_Empresa.ToString() + "', '" + Inicio_Actividades_Empresa.ToString() + "', '" + Ingresos_Brutos_Empresa.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla empresa.
        /// </summary>
        /// <param name="Id_Empresa">ID de la tabla</param>
        /// <param name="Id_Localidad">Localidad de la empresa</param>
        /// <param name="Id_Tercero_IVA">IVA de la empresa</param>
        /// <param name="Razon_Social_Empresa">Razon Social o nombre de la empresa</param>
        /// <param name="Titular_Empresa">Titular de dueño de la empresa</param>
        /// <param name="CUIT_Empresa">CUIT de la empresa</param>
        /// <param name="Direccion_Empresa">Direccion de la empresa</param>
        /// <param name="Telefonos_Empresa">Telefonos de la empresa</param>
        /// <param name="Fax_Empresa">Fax de la empresa</param>
        /// <param name="Email_Empresa">Email de la empresa</param>
        /// <param name="Web_Empresa">Web de la empresa</param>
        /// <param name="Inicio_Actividades_Empresa">Cuando se inicio la actividad de la empresa</param>
        /// <param name="Ingresos_Brutos_Empresa">Ingresos brutos de la empresa</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Empresa, int Id_Localidad, int Id_Tercero_IVA, string Razon_Social_Empresa, string Titular_Empresa, string CUIT_Empresa, string Direccion_Empresa, string Telefonos_Empresa, string Fax_Empresa, string Email_Empresa, string Web_Empresa, DateTime Inicio_Actividades_Empresa, string Ingresos_Brutos_Empresa, string Filtro)
        {
            return "UPDATE empresa SET `Id_Empresa` = '" + Id_Empresa.ToString() + "', `Id_Localidad` = '" + Id_Localidad.ToString() + "', `Id_Tercero_IVA` = '" + Id_Tercero_IVA.ToString() + "', `Razon_Social_Empresa` = '" + Razon_Social_Empresa.ToString() + "', `Titular_Empresa` = '" + Titular_Empresa.ToString() + "', `CUIT_Empresa` = '" + CUIT_Empresa.ToString() + "', `Direccion_Empresa` = '" + Direccion_Empresa.ToString() + "', `Telefonos_Empresa` = '" + Telefonos_Empresa.ToString() + "', `Fax_Empresa` = '" + Fax_Empresa.ToString() + "', `Email_Empresa` = '" + Email_Empresa.ToString() + "', `Web_Empresa` = '" + Web_Empresa.ToString() + "', `Inicio_Actividades_Empresa` = '" + Inicio_Actividades_Empresa.ToString() + "', `Ingresos_Brutos_Empresa` = '" + Ingresos_Brutos_Empresa.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Empresa.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Empresa</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Empresa Obj)
        {
            if (Obj.Razon_Social_Empresa == null)
            {
                throw new Exception("Razon_Social_Empresa no puede ser null");
            }
            if (Obj.Titular_Empresa == null)
            {
                throw new Exception("Titular_Empresa no puede ser null");
            }
            if (Obj.CUIT_Empresa == null)
            {
                throw new Exception("CUIT_Empresa no puede ser null");
            }
            if (Obj.Direccion_Empresa == null)
            {
                throw new Exception("Direccion_Empresa no puede ser null");
            }
            if (Obj.Telefonos_Empresa == null)
            {
                throw new Exception("Telefonos_Empresa no puede ser null");
            }
            if (Obj.Fax_Empresa == null)
            {
                throw new Exception("Fax_Empresa no puede ser null");
            }
            if (Obj.Email_Empresa == null)
            {
                throw new Exception("Email_Empresa no puede ser null");
            }
            if (Obj.Web_Empresa == null)
            {
                throw new Exception("Web_Empresa no puede ser null");
            }
            if (Obj.Inicio_Actividades_Empresa == null)
            {
                throw new Exception("Inicio_Actividades_Empresa no puede ser null");
            }
            if (Obj.Ingresos_Brutos_Empresa == null)
            {
                throw new Exception("Ingresos_Brutos_Empresa no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO empresa(`Id_Localidad`, `Id_Tercero_IVA`, `Razon_Social_Empresa`, `Titular_Empresa`, `CUIT_Empresa`, `Direccion_Empresa`, `Telefonos_Empresa`, `Fax_Empresa`, `Email_Empresa`, `Web_Empresa`, `Inicio_Actividades_Empresa`, `Ingresos_Brutos_Empresa`)VALUES( " + "'" + Obj.Id_Localidad.ToString() + "', " + "'" + Obj.Id_Tercero_IVA.ToString() + "', " + "'" + Obj.Razon_Social_Empresa + "', " + "'" + Obj.Titular_Empresa + "', " + "'" + Obj.CUIT_Empresa + "', " + "'" + Obj.Direccion_Empresa + "', " + "'" + Obj.Telefonos_Empresa + "', " + "'" + Obj.Fax_Empresa + "', " + "'" + Obj.Email_Empresa + "', " + "'" + Obj.Web_Empresa + "', " + "'" + Obj.Inicio_Actividades_Empresa.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Ingresos_Brutos_Empresa + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Empresa.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Empresa</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Empresa Obj)
        {
            if (Obj.Razon_Social_Empresa == null)
            {
                throw new Exception("Razon_Social_Empresa no puede ser null");
            }
            if (Obj.Titular_Empresa == null)
            {
                throw new Exception("Titular_Empresa no puede ser null");
            }
            if (Obj.CUIT_Empresa == null)
            {
                throw new Exception("CUIT_Empresa no puede ser null");
            }
            if (Obj.Direccion_Empresa == null)
            {
                throw new Exception("Direccion_Empresa no puede ser null");
            }
            if (Obj.Telefonos_Empresa == null)
            {
                throw new Exception("Telefonos_Empresa no puede ser null");
            }
            if (Obj.Fax_Empresa == null)
            {
                throw new Exception("Fax_Empresa no puede ser null");
            }
            if (Obj.Email_Empresa == null)
            {
                throw new Exception("Email_Empresa no puede ser null");
            }
            if (Obj.Web_Empresa == null)
            {
                throw new Exception("Web_Empresa no puede ser null");
            }
            if (Obj.Inicio_Actividades_Empresa == null)
            {
                throw new Exception("Inicio_Actividades_Empresa no puede ser null");
            }
            if (Obj.Ingresos_Brutos_Empresa == null)
            {
                throw new Exception("Ingresos_Brutos_Empresa no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE empresa SET `Id_Localidad` =  '" + Obj.Id_Localidad.ToString() + "', `Id_Tercero_IVA` =  '" + Obj.Id_Tercero_IVA.ToString() + "', `Razon_Social_Empresa` =  '" + Obj.Razon_Social_Empresa + "', `Titular_Empresa` =  '" + Obj.Titular_Empresa + "', `CUIT_Empresa` =  '" + Obj.CUIT_Empresa + "', `Direccion_Empresa` =  '" + Obj.Direccion_Empresa + "', `Telefonos_Empresa` =  '" + Obj.Telefonos_Empresa + "', `Fax_Empresa` =  '" + Obj.Fax_Empresa + "', `Email_Empresa` =  '" + Obj.Email_Empresa + "', `Web_Empresa` =  '" + Obj.Web_Empresa + "', `Inicio_Actividades_Empresa` =  '" + Obj.Inicio_Actividades_Empresa.ToString("yyyy-MM-dd HH:mm:ss") + "', `Ingresos_Brutos_Empresa` =  '" + Obj.Ingresos_Brutos_Empresa + "' WHERE empresa.Id_Empresa = " + Obj.Id_Empresa.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Empresa.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM empresa WHERE empresa.Id_Empresa = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Empresa. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Empresa</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Empresa Obj)
        {
            if (Obj.Razon_Social_Empresa == null)
            {
                throw new Exception("Razon_Social_Empresa no puede ser null");
            }
            if (Obj.Titular_Empresa == null)
            {
                throw new Exception("Titular_Empresa no puede ser null");
            }
            if (Obj.CUIT_Empresa == null)
            {
                throw new Exception("CUIT_Empresa no puede ser null");
            }
            if (Obj.Direccion_Empresa == null)
            {
                throw new Exception("Direccion_Empresa no puede ser null");
            }
            if (Obj.Telefonos_Empresa == null)
            {
                throw new Exception("Telefonos_Empresa no puede ser null");
            }
            if (Obj.Fax_Empresa == null)
            {
                throw new Exception("Fax_Empresa no puede ser null");
            }
            if (Obj.Email_Empresa == null)
            {
                throw new Exception("Email_Empresa no puede ser null");
            }
            if (Obj.Web_Empresa == null)
            {
                throw new Exception("Web_Empresa no puede ser null");
            }
            if (Obj.Inicio_Actividades_Empresa == null)
            {
                throw new Exception("Inicio_Actividades_Empresa no puede ser null");
            }
            if (Obj.Ingresos_Brutos_Empresa == null)
            {
                throw new Exception("Ingresos_Brutos_Empresa no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO empresa(`Id_Localidad`, `Id_Tercero_IVA`, `Razon_Social_Empresa`, `Titular_Empresa`, `CUIT_Empresa`, `Direccion_Empresa`, `Telefonos_Empresa`, `Fax_Empresa`, `Email_Empresa`, `Web_Empresa`, `Inicio_Actividades_Empresa`, `Ingresos_Brutos_Empresa`)VALUES( " + "'" + Obj.Id_Localidad.ToString() + "', " + "'" + Obj.Id_Tercero_IVA.ToString() + "', " + "'" + Obj.Razon_Social_Empresa + "', " + "'" + Obj.Titular_Empresa + "', " + "'" + Obj.CUIT_Empresa + "', " + "'" + Obj.Direccion_Empresa + "', " + "'" + Obj.Telefonos_Empresa + "', " + "'" + Obj.Fax_Empresa + "', " + "'" + Obj.Email_Empresa + "', " + "'" + Obj.Web_Empresa + "', " + "'" + Obj.Inicio_Actividades_Empresa.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Ingresos_Brutos_Empresa + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Empresa. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Empresa</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Empresa Obj)
        {
            if (Obj.Razon_Social_Empresa == null)
            {
                throw new Exception("Razon_Social_Empresa no puede ser null");
            }
            if (Obj.Titular_Empresa == null)
            {
                throw new Exception("Titular_Empresa no puede ser null");
            }
            if (Obj.CUIT_Empresa == null)
            {
                throw new Exception("CUIT_Empresa no puede ser null");
            }
            if (Obj.Direccion_Empresa == null)
            {
                throw new Exception("Direccion_Empresa no puede ser null");
            }
            if (Obj.Telefonos_Empresa == null)
            {
                throw new Exception("Telefonos_Empresa no puede ser null");
            }
            if (Obj.Fax_Empresa == null)
            {
                throw new Exception("Fax_Empresa no puede ser null");
            }
            if (Obj.Email_Empresa == null)
            {
                throw new Exception("Email_Empresa no puede ser null");
            }
            if (Obj.Web_Empresa == null)
            {
                throw new Exception("Web_Empresa no puede ser null");
            }
            if (Obj.Inicio_Actividades_Empresa == null)
            {
                throw new Exception("Inicio_Actividades_Empresa no puede ser null");
            }
            if (Obj.Ingresos_Brutos_Empresa == null)
            {
                throw new Exception("Ingresos_Brutos_Empresa no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE empresa SET `Id_Localidad` =  '" + Obj.Id_Localidad.ToString() + "', `Id_Tercero_IVA` =  '" + Obj.Id_Tercero_IVA.ToString() + "', `Razon_Social_Empresa` =  '" + Obj.Razon_Social_Empresa + "', `Titular_Empresa` =  '" + Obj.Titular_Empresa + "', `CUIT_Empresa` =  '" + Obj.CUIT_Empresa + "', `Direccion_Empresa` =  '" + Obj.Direccion_Empresa + "', `Telefonos_Empresa` =  '" + Obj.Telefonos_Empresa + "', `Fax_Empresa` =  '" + Obj.Fax_Empresa + "', `Email_Empresa` =  '" + Obj.Email_Empresa + "', `Web_Empresa` =  '" + Obj.Web_Empresa + "', `Inicio_Actividades_Empresa` =  '" + Obj.Inicio_Actividades_Empresa.ToString("yyyy-MM-dd HH:mm:ss") + "', `Ingresos_Brutos_Empresa` =  '" + Obj.Ingresos_Brutos_Empresa + "' WHERE empresa.Id_Empresa = " + Obj.Id_Empresa.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Empresa. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM empresa WHERE empresa.Id_Empresa = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Aca van todas las facturas
    /// La última modificación fué el lunes, 10 de octubre de 2011 a las 10:59:25 a.m.
    /// </summary>
    public partial class Factura
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura</param>
        public Factura(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura"))
            {
                if (DataRowConstructor["Id_Factura"] != DBNull.Value)
                {
                    this.Id_Factura = Convert.ToInt32(DataRowConstructor["Id_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero"))
            {
                if (DataRowConstructor["Id_Tercero"] != DBNull.Value)
                {
                    this.Id_Tercero = Convert.ToInt32(DataRowConstructor["Id_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Tipo"))
            {
                if (DataRowConstructor["Id_Factura_Tipo"] != DBNull.Value)
                {
                    this.Id_Factura_Tipo = Convert.ToInt32(DataRowConstructor["Id_Factura_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Factura"))
            {
                if (DataRowConstructor["Fecha_Factura"] != DBNull.Value)
                {
                    this.Fecha_Factura = Convert.ToDateTime(DataRowConstructor["Fecha_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Vencimiento_Factura"))
            {
                if (DataRowConstructor["Fecha_Vencimiento_Factura"] != DBNull.Value)
                {
                    this.Fecha_Vencimiento_Factura = Convert.ToDateTime(DataRowConstructor["Fecha_Vencimiento_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Clase_Factura"))
            {
                if (DataRowConstructor["Clase_Factura"] != DBNull.Value)
                {
                    this.Clase_Factura = DataRowConstructor["Clase_Factura"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Puesto_Factura"))
            {
                if (DataRowConstructor["Puesto_Factura"] != DBNull.Value)
                {
                    this.Puesto_Factura = Convert.ToInt32(DataRowConstructor["Puesto_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Factura"))
            {
                if (DataRowConstructor["Numero_Factura"] != DBNull.Value)
                {
                    this.Numero_Factura = Convert.ToInt32(DataRowConstructor["Numero_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Neto_Factura"))
            {
                if (DataRowConstructor["Neto_Factura"] != DBNull.Value)
                {
                    this.Neto_Factura = Convert.ToDecimal(DataRowConstructor["Neto_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("IVA_105_Factura"))
            {
                if (DataRowConstructor["IVA_105_Factura"] != DBNull.Value)
                {
                    this.IVA_105_Factura = Convert.ToDecimal(DataRowConstructor["IVA_105_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("IVA_21_Factura"))
            {
                if (DataRowConstructor["IVA_21_Factura"] != DBNull.Value)
                {
                    this.IVA_21_Factura = Convert.ToDecimal(DataRowConstructor["IVA_21_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("IVA_27_Factura"))
            {
                if (DataRowConstructor["IVA_27_Factura"] != DBNull.Value)
                {
                    this.IVA_27_Factura = Convert.ToDecimal(DataRowConstructor["IVA_27_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Percepcion_Factura"))
            {
                if (DataRowConstructor["Percepcion_Factura"] != DBNull.Value)
                {
                    this.Percepcion_Factura = Convert.ToDecimal(DataRowConstructor["Percepcion_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Exentos_Factura"))
            {
                if (DataRowConstructor["Exentos_Factura"] != DBNull.Value)
                {
                    this.Exentos_Factura = Convert.ToDecimal(DataRowConstructor["Exentos_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Otros_Factura"))
            {
                if (DataRowConstructor["Otros_Factura"] != DBNull.Value)
                {
                    this.Otros_Factura = Convert.ToDecimal(DataRowConstructor["Otros_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Total_Factura"))
            {
                if (DataRowConstructor["Total_Factura"] != DBNull.Value)
                {
                    this.Total_Factura = Convert.ToDecimal(DataRowConstructor["Total_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Retencion_Factura"))
            {
                if (DataRowConstructor["Retencion_Factura"] != DBNull.Value)
                {
                    this.Retencion_Factura = Convert.ToDecimal(DataRowConstructor["Retencion_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Interes_Factura"))
            {
                if (DataRowConstructor["Interes_Factura"] != DBNull.Value)
                {
                    this.Interes_Factura = Convert.ToDecimal(DataRowConstructor["Interes_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Anulado_Factura"))
            {
                if (DataRowConstructor["Anulado_Factura"] != DBNull.Value)
                {
                    this.Anulado_Factura = Convert.ToBoolean(DataRowConstructor["Anulado_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Facturado_Factura"))
            {
                if (DataRowConstructor["Facturado_Factura"] != DBNull.Value)
                {
                    this.Facturado_Factura = Convert.ToBoolean(DataRowConstructor["Facturado_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Pagado_Factura"))
            {
                if (DataRowConstructor["Pagado_Factura"] != DBNull.Value)
                {
                    this.Pagado_Factura = Convert.ToBoolean(DataRowConstructor["Pagado_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Factura"))
            {
                if (DataRowConstructor["Observaciones_Factura"] != DBNull.Value)
                {
                    this.Observaciones_Factura = DataRowConstructor["Observaciones_Factura"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura</param>
        public Factura(DataSet DataSetConstructor)
        {
            this.ListaFactura = new List<Factura>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura TEMP = new Factura(Fila);
                TEMP.Tercero = new Tercero(Fila);
                TEMP.Factura_tipo = new Factura_tipo(Fila);
                this.ListaFactura.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura> ListaFactura { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura { get; set; }
        /// <summary>
        /// ID del tercero responsable del comprobante
        /// </summary>
        public int Id_Tercero { get; set; }
        /// <summary>
        /// Tipo de factura
        /// </summary>
        public int Id_Factura_Tipo { get; set; }
        /// <summary>
        /// Facha en que se realiaza la factura
        /// </summary>
        public DateTime Fecha_Factura { get; set; }
        /// <summary>
        /// Fecha de vencimiento de la factura
        /// </summary>
        public DateTime Fecha_Vencimiento_Factura { get; set; }
        /// <summary>
        /// Clase de la factura
        /// </summary>
        public string Clase_Factura { get; set; }
        /// <summary>
        /// Puesto de la factura
        /// </summary>
        public int Puesto_Factura { get; set; }
        /// <summary>
        /// Numero de la factura
        /// </summary>
        public int Numero_Factura { get; set; }
        /// <summary>
        /// Valor total del Neto de la factura
        /// </summary>
        public decimal Neto_Factura { get; set; }
        /// <summary>
        /// Valor total de los articulos con IVA 10,5%
        /// </summary>
        public decimal IVA_105_Factura { get; set; }
        /// <summary>
        /// Valor total de los articulos con IVA 21%
        /// </summary>
        public decimal IVA_21_Factura { get; set; }
        /// <summary>
        /// Valor total de los articulos con IVA 27%
        /// </summary>
        public decimal IVA_27_Factura { get; set; }
        /// <summary>
        /// Valor de la percepcion
        /// </summary>
        public decimal Percepcion_Factura { get; set; }
        /// <summary>
        /// Valor total de los articulos sin IVA
        /// </summary>
        public decimal Exentos_Factura { get; set; }
        /// <summary>
        /// Otros valores, recargos, importes internos, etc.
        /// </summary>
        public decimal Otros_Factura { get; set; }
        /// <summary>
        /// Total de la factura
        /// </summary>
        public decimal Total_Factura { get; set; }
        /// <summary>
        /// Retencion de la factura
        /// </summary>
        public decimal Retencion_Factura { get; set; }
        /// <summary>
        /// Interes que se le agrega a las cuotas
        /// </summary>
        public decimal Interes_Factura { get; set; }
        /// <summary>
        /// Si es verdadero la factura esta anulada
        /// </summary>
        public bool Anulado_Factura { get; set; }
        /// <summary>
        /// Si es verdadero la factura esta facturada
        /// </summary>
        public bool Facturado_Factura { get; set; }
        /// <summary>
        /// Se usa para los proveedores, para saber cuando esta pagada la factura de compra
        /// </summary>
        public bool Pagado_Factura { get; set; }
        /// <summary>
        /// Observaciones de la factura
        /// </summary>
        public string Observaciones_Factura { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero, Guarda los cliente y los proveedores
        /// </summary>
        public Tercero Tercero { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura_tipo, Tipo de comprobantes
        /// </summary>
        public Factura_tipo Factura_tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura`, `Id_Tercero`, `Id_Factura_Tipo`, `Fecha_Factura`, `Fecha_Vencimiento_Factura`, `Clase_Factura`, `Puesto_Factura`, `Numero_Factura`, `Neto_Factura`, `IVA_105_Factura`, `IVA_21_Factura`, `IVA_27_Factura`, `Percepcion_Factura`, `Exentos_Factura`, `Otros_Factura`, `Total_Factura`, `Retencion_Factura`, `Interes_Factura`, `Anulado_Factura`, `Facturado_Factura`, `Pagado_Factura`, `Observaciones_Factura` FROM factura " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura.
        /// </summary>
        /// <param name="Id_Factura">ID de la tabla</param>
        /// <param name="Id_Tercero">ID del tercero responsable del comprobante</param>
        /// <param name="Id_Factura_Tipo">Tipo de factura</param>
        /// <param name="Fecha_Factura">Facha en que se realiaza la factura</param>
        /// <param name="Fecha_Vencimiento_Factura">Fecha de vencimiento de la factura</param>
        /// <param name="Clase_Factura">Clase de la factura</param>
        /// <param name="Puesto_Factura">Puesto de la factura</param>
        /// <param name="Numero_Factura">Numero de la factura</param>
        /// <param name="Neto_Factura">Valor total del Neto de la factura</param>
        /// <param name="IVA_105_Factura">Valor total de los articulos con IVA 10,5%</param>
        /// <param name="IVA_21_Factura">Valor total de los articulos con IVA 21%</param>
        /// <param name="IVA_27_Factura">Valor total de los articulos con IVA 27%</param>
        /// <param name="Percepcion_Factura">Valor de la percepcion</param>
        /// <param name="Exentos_Factura">Valor total de los articulos sin IVA</param>
        /// <param name="Otros_Factura">Otros valores, recargos, importes internos, etc.</param>
        /// <param name="Total_Factura">Total de la factura</param>
        /// <param name="Retencion_Factura">Retencion de la factura</param>
        /// <param name="Interes_Factura">Interes que se le agrega a las cuotas</param>
        /// <param name="Anulado_Factura">Si es verdadero la factura esta anulada</param>
        /// <param name="Facturado_Factura">Si es verdadero la factura esta facturada</param>
        /// <param name="Pagado_Factura">Se usa para los proveedores, para saber cuando esta pagada la factura de compra</param>
        /// <param name="Observaciones_Factura">Observaciones de la factura</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura, int Id_Tercero, int Id_Factura_Tipo, DateTime Fecha_Factura, DateTime Fecha_Vencimiento_Factura, string Clase_Factura, int Puesto_Factura, int Numero_Factura, decimal Neto_Factura, decimal IVA_105_Factura, decimal IVA_21_Factura, decimal IVA_27_Factura, decimal Percepcion_Factura, decimal Exentos_Factura, decimal Otros_Factura, decimal Total_Factura, decimal Retencion_Factura, decimal Interes_Factura, bool Anulado_Factura, bool Facturado_Factura, bool Pagado_Factura, string Observaciones_Factura)
        {
            return "INSERT INTO factura(`Id_Factura`, `Id_Tercero`, `Id_Factura_Tipo`, `Fecha_Factura`, `Fecha_Vencimiento_Factura`, `Clase_Factura`, `Puesto_Factura`, `Numero_Factura`, `Neto_Factura`, `IVA_105_Factura`, `IVA_21_Factura`, `IVA_27_Factura`, `Percepcion_Factura`, `Exentos_Factura`, `Otros_Factura`, `Total_Factura`, `Retencion_Factura`, `Interes_Factura`, `Anulado_Factura`, `Facturado_Factura`, `Pagado_Factura`, `Observaciones_Factura`) VALUES ('" + Id_Factura.ToString() + "', '" + Id_Tercero.ToString() + "', '" + Id_Factura_Tipo.ToString() + "', '" + Fecha_Factura.ToString() + "', '" + Fecha_Vencimiento_Factura.ToString() + "', '" + Clase_Factura.ToString() + "', '" + Puesto_Factura.ToString() + "', '" + Numero_Factura.ToString() + "', '" + Neto_Factura.ToString() + "', '" + IVA_105_Factura.ToString() + "', '" + IVA_21_Factura.ToString() + "', '" + IVA_27_Factura.ToString() + "', '" + Percepcion_Factura.ToString() + "', '" + Exentos_Factura.ToString() + "', '" + Otros_Factura.ToString() + "', '" + Total_Factura.ToString() + "', '" + Retencion_Factura.ToString() + "', '" + Interes_Factura.ToString() + "', '" + Anulado_Factura.ToString() + "', '" + Facturado_Factura.ToString() + "', '" + Pagado_Factura.ToString() + "', '" + Observaciones_Factura.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura.
        /// </summary>
        /// <param name="Id_Factura">ID de la tabla</param>
        /// <param name="Id_Tercero">ID del tercero responsable del comprobante</param>
        /// <param name="Id_Factura_Tipo">Tipo de factura</param>
        /// <param name="Fecha_Factura">Facha en que se realiaza la factura</param>
        /// <param name="Fecha_Vencimiento_Factura">Fecha de vencimiento de la factura</param>
        /// <param name="Clase_Factura">Clase de la factura</param>
        /// <param name="Puesto_Factura">Puesto de la factura</param>
        /// <param name="Numero_Factura">Numero de la factura</param>
        /// <param name="Neto_Factura">Valor total del Neto de la factura</param>
        /// <param name="IVA_105_Factura">Valor total de los articulos con IVA 10,5%</param>
        /// <param name="IVA_21_Factura">Valor total de los articulos con IVA 21%</param>
        /// <param name="IVA_27_Factura">Valor total de los articulos con IVA 27%</param>
        /// <param name="Percepcion_Factura">Valor de la percepcion</param>
        /// <param name="Exentos_Factura">Valor total de los articulos sin IVA</param>
        /// <param name="Otros_Factura">Otros valores, recargos, importes internos, etc.</param>
        /// <param name="Total_Factura">Total de la factura</param>
        /// <param name="Retencion_Factura">Retencion de la factura</param>
        /// <param name="Interes_Factura">Interes que se le agrega a las cuotas</param>
        /// <param name="Anulado_Factura">Si es verdadero la factura esta anulada</param>
        /// <param name="Facturado_Factura">Si es verdadero la factura esta facturada</param>
        /// <param name="Pagado_Factura">Se usa para los proveedores, para saber cuando esta pagada la factura de compra</param>
        /// <param name="Observaciones_Factura">Observaciones de la factura</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura, int Id_Tercero, int Id_Factura_Tipo, DateTime Fecha_Factura, DateTime Fecha_Vencimiento_Factura, string Clase_Factura, int Puesto_Factura, int Numero_Factura, decimal Neto_Factura, decimal IVA_105_Factura, decimal IVA_21_Factura, decimal IVA_27_Factura, decimal Percepcion_Factura, decimal Exentos_Factura, decimal Otros_Factura, decimal Total_Factura, decimal Retencion_Factura, decimal Interes_Factura, bool Anulado_Factura, bool Facturado_Factura, bool Pagado_Factura, string Observaciones_Factura, string Filtro)
        {
            return "UPDATE factura SET `Id_Factura` = '" + Id_Factura.ToString() + "', `Id_Tercero` = '" + Id_Tercero.ToString() + "', `Id_Factura_Tipo` = '" + Id_Factura_Tipo.ToString() + "', `Fecha_Factura` = '" + Fecha_Factura.ToString() + "', `Fecha_Vencimiento_Factura` = '" + Fecha_Vencimiento_Factura.ToString() + "', `Clase_Factura` = '" + Clase_Factura.ToString() + "', `Puesto_Factura` = '" + Puesto_Factura.ToString() + "', `Numero_Factura` = '" + Numero_Factura.ToString() + "', `Neto_Factura` = '" + Neto_Factura.ToString() + "', `IVA_105_Factura` = '" + IVA_105_Factura.ToString() + "', `IVA_21_Factura` = '" + IVA_21_Factura.ToString() + "', `IVA_27_Factura` = '" + IVA_27_Factura.ToString() + "', `Percepcion_Factura` = '" + Percepcion_Factura.ToString() + "', `Exentos_Factura` = '" + Exentos_Factura.ToString() + "', `Otros_Factura` = '" + Otros_Factura.ToString() + "', `Total_Factura` = '" + Total_Factura.ToString() + "', `Retencion_Factura` = '" + Retencion_Factura.ToString() + "', `Interes_Factura` = '" + Interes_Factura.ToString() + "', `Anulado_Factura` = '" + Anulado_Factura.ToString() + "', `Facturado_Factura` = '" + Facturado_Factura.ToString() + "', `Pagado_Factura` = '" + Pagado_Factura.ToString() + "', `Observaciones_Factura` = '" + Observaciones_Factura.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura Obj)
        {
            if (Obj.Fecha_Factura == null)
            {
                throw new Exception("Fecha_Factura no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Factura == null)
            {
                throw new Exception("Fecha_Vencimiento_Factura no puede ser null");
            }
            if (Obj.Clase_Factura == null)
            {
                throw new Exception("Clase_Factura no puede ser null");
            }
            if (Obj.Observaciones_Factura == null)
            {
                throw new Exception("Observaciones_Factura no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura(`Id_Tercero`, `Id_Factura_Tipo`, `Fecha_Factura`, `Fecha_Vencimiento_Factura`, `Clase_Factura`, `Puesto_Factura`, `Numero_Factura`, `Neto_Factura`, `IVA_105_Factura`, `IVA_21_Factura`, `IVA_27_Factura`, `Percepcion_Factura`, `Exentos_Factura`, `Otros_Factura`, `Total_Factura`, `Retencion_Factura`, `Interes_Factura`, `Anulado_Factura`, `Facturado_Factura`, `Pagado_Factura`, `Observaciones_Factura`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Id_Factura_Tipo.ToString() + "', " + "'" + Obj.Fecha_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Vencimiento_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Clase_Factura + "', " + "'" + Obj.Puesto_Factura.ToString() + "', " + "'" + Obj.Numero_Factura.ToString() + "', " + "'" + Obj.Neto_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_105_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_21_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_27_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Percepcion_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Exentos_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Otros_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Total_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Retencion_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Interes_Factura.ToString().Replace(",", ".") + "', " + Common.BoolToString(Obj.Anulado_Factura) + ", " + Common.BoolToString(Obj.Facturado_Factura) + ", " + Common.BoolToString(Obj.Pagado_Factura) + ", " + "'" + Obj.Observaciones_Factura + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Factura.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura Obj)
        {
            if (Obj.Fecha_Factura == null)
            {
                throw new Exception("Fecha_Factura no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Factura == null)
            {
                throw new Exception("Fecha_Vencimiento_Factura no puede ser null");
            }
            if (Obj.Clase_Factura == null)
            {
                throw new Exception("Clase_Factura no puede ser null");
            }
            if (Obj.Observaciones_Factura == null)
            {
                throw new Exception("Observaciones_Factura no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Id_Factura_Tipo` =  '" + Obj.Id_Factura_Tipo.ToString() + "', `Fecha_Factura` =  '" + Obj.Fecha_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Vencimiento_Factura` =  '" + Obj.Fecha_Vencimiento_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', `Clase_Factura` =  '" + Obj.Clase_Factura + "', `Puesto_Factura` =  '" + Obj.Puesto_Factura.ToString() + "', `Numero_Factura` =  '" + Obj.Numero_Factura.ToString() + "', `Neto_Factura` =  '" + Obj.Neto_Factura.ToString().Replace(",", ".") + "', `IVA_105_Factura` =  '" + Obj.IVA_105_Factura.ToString().Replace(",", ".") + "', `IVA_21_Factura` =  '" + Obj.IVA_21_Factura.ToString().Replace(",", ".") + "', `IVA_27_Factura` =  '" + Obj.IVA_27_Factura.ToString().Replace(",", ".") + "', `Percepcion_Factura` =  '" + Obj.Percepcion_Factura.ToString().Replace(",", ".") + "', `Exentos_Factura` =  '" + Obj.Exentos_Factura.ToString().Replace(",", ".") + "', `Otros_Factura` =  '" + Obj.Otros_Factura.ToString().Replace(",", ".") + "', `Total_Factura` =  '" + Obj.Total_Factura.ToString().Replace(",", ".") + "', `Retencion_Factura` =  '" + Obj.Retencion_Factura.ToString().Replace(",", ".") + "', `Interes_Factura` =  '" + Obj.Interes_Factura.ToString().Replace(",", ".") + "', `Anulado_Factura` = " + Common.BoolToString(Obj.Anulado_Factura) + ", `Facturado_Factura` = " + Common.BoolToString(Obj.Facturado_Factura) + ", `Pagado_Factura` = " + Common.BoolToString(Obj.Pagado_Factura) + ", `Observaciones_Factura` =  '" + Obj.Observaciones_Factura + "' WHERE factura.Id_Factura = " + Obj.Id_Factura.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Factura.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura WHERE factura.Id_Factura = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Factura. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura Obj)
        {
            if (Obj.Fecha_Factura == null)
            {
                throw new Exception("Fecha_Factura no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Factura == null)
            {
                throw new Exception("Fecha_Vencimiento_Factura no puede ser null");
            }
            if (Obj.Clase_Factura == null)
            {
                throw new Exception("Clase_Factura no puede ser null");
            }
            if (Obj.Observaciones_Factura == null)
            {
                throw new Exception("Observaciones_Factura no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO factura(`Id_Tercero`, `Id_Factura_Tipo`, `Fecha_Factura`, `Fecha_Vencimiento_Factura`, `Clase_Factura`, `Puesto_Factura`, `Numero_Factura`, `Neto_Factura`, `IVA_105_Factura`, `IVA_21_Factura`, `IVA_27_Factura`, `Percepcion_Factura`, `Exentos_Factura`, `Otros_Factura`, `Total_Factura`, `Retencion_Factura`, `Interes_Factura`, `Anulado_Factura`, `Facturado_Factura`, `Pagado_Factura`, `Observaciones_Factura`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Id_Factura_Tipo.ToString() + "', " + "'" + Obj.Fecha_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Vencimiento_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Clase_Factura + "', " + "'" + Obj.Puesto_Factura.ToString() + "', " + "'" + Obj.Numero_Factura.ToString() + "', " + "'" + Obj.Neto_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_105_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_21_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_27_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Percepcion_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Exentos_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Otros_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Total_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Retencion_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Interes_Factura.ToString().Replace(",", ".") + "', " + Common.BoolToString(Obj.Anulado_Factura) + ", " + Common.BoolToString(Obj.Facturado_Factura) + ", " + Common.BoolToString(Obj.Pagado_Factura) + ", " + "'" + Obj.Observaciones_Factura + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura Obj)
        {
            if (Obj.Fecha_Factura == null)
            {
                throw new Exception("Fecha_Factura no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Factura == null)
            {
                throw new Exception("Fecha_Vencimiento_Factura no puede ser null");
            }
            if (Obj.Clase_Factura == null)
            {
                throw new Exception("Clase_Factura no puede ser null");
            }
            if (Obj.Observaciones_Factura == null)
            {
                throw new Exception("Observaciones_Factura no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE factura SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Id_Factura_Tipo` =  '" + Obj.Id_Factura_Tipo.ToString() + "', `Fecha_Factura` =  '" + Obj.Fecha_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Vencimiento_Factura` =  '" + Obj.Fecha_Vencimiento_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', `Clase_Factura` =  '" + Obj.Clase_Factura + "', `Puesto_Factura` =  '" + Obj.Puesto_Factura.ToString() + "', `Numero_Factura` =  '" + Obj.Numero_Factura.ToString() + "', `Neto_Factura` =  '" + Obj.Neto_Factura.ToString().Replace(",", ".") + "', `IVA_105_Factura` =  '" + Obj.IVA_105_Factura.ToString().Replace(",", ".") + "', `IVA_21_Factura` =  '" + Obj.IVA_21_Factura.ToString().Replace(",", ".") + "', `IVA_27_Factura` =  '" + Obj.IVA_27_Factura.ToString().Replace(",", ".") + "', `Percepcion_Factura` =  '" + Obj.Percepcion_Factura.ToString().Replace(",", ".") + "', `Exentos_Factura` =  '" + Obj.Exentos_Factura.ToString().Replace(",", ".") + "', `Otros_Factura` =  '" + Obj.Otros_Factura.ToString().Replace(",", ".") + "', `Total_Factura` =  '" + Obj.Total_Factura.ToString().Replace(",", ".") + "', `Retencion_Factura` =  '" + Obj.Retencion_Factura.ToString().Replace(",", ".") + "', `Interes_Factura` =  '" + Obj.Interes_Factura.ToString().Replace(",", ".") + "', `Anulado_Factura` = " + Common.BoolToString(Obj.Anulado_Factura) + ", `Facturado_Factura` = " + Common.BoolToString(Obj.Facturado_Factura) + ", `Pagado_Factura` = " + Common.BoolToString(Obj.Pagado_Factura) + ", `Observaciones_Factura` =  '" + Obj.Observaciones_Factura + "' WHERE factura.Id_Factura = " + Obj.Id_Factura.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura WHERE factura.Id_Factura = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Detalle de la factura, los articulos.
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:35 a.m.
    /// </summary>
    public partial class Factura_detalle
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura_detalle()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura_detalle</param>
        public Factura_detalle(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Detalle"))
            {
                if (DataRowConstructor["Id_Factura_Detalle"] != DBNull.Value)
                {
                    this.Id_Factura_Detalle = Convert.ToInt32(DataRowConstructor["Id_Factura_Detalle"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura"))
            {
                if (DataRowConstructor["Id_Factura"] != DBNull.Value)
                {
                    this.Id_Factura = Convert.ToInt32(DataRowConstructor["Id_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Articulo"))
            {
                if (DataRowConstructor["Id_Articulo"] != DBNull.Value)
                {
                    this.Id_Articulo = Convert.ToInt32(DataRowConstructor["Id_Articulo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Cantidad_Factura_Detalle"))
            {
                if (DataRowConstructor["Cantidad_Factura_Detalle"] != DBNull.Value)
                {
                    this.Cantidad_Factura_Detalle = Convert.ToInt32(DataRowConstructor["Cantidad_Factura_Detalle"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Precio_Unitario_Factura_Detalle"))
            {
                if (DataRowConstructor["Precio_Unitario_Factura_Detalle"] != DBNull.Value)
                {
                    this.Precio_Unitario_Factura_Detalle = Convert.ToDecimal(DataRowConstructor["Precio_Unitario_Factura_Detalle"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Bonifica_Factura_Detalle"))
            {
                if (DataRowConstructor["Bonifica_Factura_Detalle"] != DBNull.Value)
                {
                    this.Bonifica_Factura_Detalle = Convert.ToDecimal(DataRowConstructor["Bonifica_Factura_Detalle"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura_detalle</param>
        public Factura_detalle(DataSet DataSetConstructor)
        {
            this.ListaFactura_detalle = new List<Factura_detalle>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura_detalle TEMP = new Factura_detalle(Fila);
                TEMP.Factura = new Factura(Fila);
                TEMP.Articulo = new Articulo(Fila);
                this.ListaFactura_detalle.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura_detalle> ListaFactura_detalle { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura_Detalle { get; set; }
        /// <summary>
        /// Id de la factura
        /// </summary>
        public int Id_Factura { get; set; }
        /// <summary>
        /// Id del articulo
        /// </summary>
        public int Id_Articulo { get; set; }
        /// <summary>
        /// Cantidad de articulos
        /// </summary>
        public int Cantidad_Factura_Detalle { get; set; }
        /// <summary>
        /// Precio unitario del articulo
        /// </summary>
        public decimal Precio_Unitario_Factura_Detalle { get; set; }
        /// <summary>
        /// Bonificacion del articulo
        /// </summary>
        public decimal Bonifica_Factura_Detalle { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura, Aca van todas las facturas
        /// </summary>
        public Factura Factura { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Articulo, Articulos del sistema
        /// </summary>
        public Articulo Articulo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura_detalle.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura_Detalle`, `Id_Factura`, `Id_Articulo`, `Cantidad_Factura_Detalle`, `Precio_Unitario_Factura_Detalle`, `Bonifica_Factura_Detalle` FROM factura_detalle " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura_detalle.
        /// </summary>
        /// <param name="Id_Factura_Detalle">ID de la tabla</param>
        /// <param name="Id_Factura">Id de la factura</param>
        /// <param name="Id_Articulo">Id del articulo</param>
        /// <param name="Cantidad_Factura_Detalle">Cantidad de articulos</param>
        /// <param name="Precio_Unitario_Factura_Detalle">Precio unitario del articulo</param>
        /// <param name="Bonifica_Factura_Detalle">Bonificacion del articulo</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura_Detalle, int Id_Factura, int Id_Articulo, int Cantidad_Factura_Detalle, decimal Precio_Unitario_Factura_Detalle, decimal Bonifica_Factura_Detalle)
        {
            return "INSERT INTO factura_detalle(`Id_Factura_Detalle`, `Id_Factura`, `Id_Articulo`, `Cantidad_Factura_Detalle`, `Precio_Unitario_Factura_Detalle`, `Bonifica_Factura_Detalle`) VALUES ('" + Id_Factura_Detalle.ToString() + "', '" + Id_Factura.ToString() + "', '" + Id_Articulo.ToString() + "', '" + Cantidad_Factura_Detalle.ToString() + "', '" + Precio_Unitario_Factura_Detalle.ToString() + "', '" + Bonifica_Factura_Detalle.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura_detalle.
        /// </summary>
        /// <param name="Id_Factura_Detalle">ID de la tabla</param>
        /// <param name="Id_Factura">Id de la factura</param>
        /// <param name="Id_Articulo">Id del articulo</param>
        /// <param name="Cantidad_Factura_Detalle">Cantidad de articulos</param>
        /// <param name="Precio_Unitario_Factura_Detalle">Precio unitario del articulo</param>
        /// <param name="Bonifica_Factura_Detalle">Bonificacion del articulo</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura_Detalle, int Id_Factura, int Id_Articulo, int Cantidad_Factura_Detalle, decimal Precio_Unitario_Factura_Detalle, decimal Bonifica_Factura_Detalle, string Filtro)
        {
            return "UPDATE factura_detalle SET `Id_Factura_Detalle` = '" + Id_Factura_Detalle.ToString() + "', `Id_Factura` = '" + Id_Factura.ToString() + "', `Id_Articulo` = '" + Id_Articulo.ToString() + "', `Cantidad_Factura_Detalle` = '" + Cantidad_Factura_Detalle.ToString() + "', `Precio_Unitario_Factura_Detalle` = '" + Precio_Unitario_Factura_Detalle.ToString() + "', `Bonifica_Factura_Detalle` = '" + Bonifica_Factura_Detalle.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_detalle.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura_detalle Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura_detalle(`Id_Factura`, `Id_Articulo`, `Cantidad_Factura_Detalle`, `Precio_Unitario_Factura_Detalle`, `Bonifica_Factura_Detalle`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Id_Articulo.ToString() + "', " + "'" + Obj.Cantidad_Factura_Detalle.ToString() + "', " + "'" + Obj.Precio_Unitario_Factura_Detalle.ToString().Replace(",", ".") + "', " + "'" + Obj.Bonifica_Factura_Detalle.ToString().Replace(",", ".") + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Factura_detalle.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura_detalle Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura_detalle SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Id_Articulo` =  '" + Obj.Id_Articulo.ToString() + "', `Cantidad_Factura_Detalle` =  '" + Obj.Cantidad_Factura_Detalle.ToString() + "', `Precio_Unitario_Factura_Detalle` =  '" + Obj.Precio_Unitario_Factura_Detalle.ToString().Replace(",", ".") + "', `Bonifica_Factura_Detalle` =  '" + Obj.Bonifica_Factura_Detalle.ToString().Replace(",", ".") + "' WHERE factura_detalle.Id_Factura_Detalle = " + Obj.Id_Factura_Detalle.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Factura_detalle.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura_detalle WHERE factura_detalle.Id_Factura_Detalle = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Factura_detalle. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura_detalle Obj)
        {
            if (Common.InsertUpdate("INSERT INTO factura_detalle(`Id_Factura`, `Id_Articulo`, `Cantidad_Factura_Detalle`, `Precio_Unitario_Factura_Detalle`, `Bonifica_Factura_Detalle`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Id_Articulo.ToString() + "', " + "'" + Obj.Cantidad_Factura_Detalle.ToString() + "', " + "'" + Obj.Precio_Unitario_Factura_Detalle.ToString().Replace(",", ".") + "', " + "'" + Obj.Bonifica_Factura_Detalle.ToString().Replace(",", ".") + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_detalle. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura_detalle Obj)
        {
            if (Common.InsertUpdate("UPDATE factura_detalle SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Id_Articulo` =  '" + Obj.Id_Articulo.ToString() + "', `Cantidad_Factura_Detalle` =  '" + Obj.Cantidad_Factura_Detalle.ToString() + "', `Precio_Unitario_Factura_Detalle` =  '" + Obj.Precio_Unitario_Factura_Detalle.ToString().Replace(",", ".") + "', `Bonifica_Factura_Detalle` =  '" + Obj.Bonifica_Factura_Detalle.ToString().Replace(",", ".") + "' WHERE factura_detalle.Id_Factura_Detalle = " + Obj.Id_Factura_Detalle.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_detalle. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura_detalle WHERE factura_detalle.Id_Factura_Detalle = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Garante asociados a las facturas correspondiente
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 05:47:42 p.m.
    /// </summary>
    public partial class Factura_garante
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura_garante()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura_garante</param>
        public Factura_garante(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Garante"))
            {
                if (DataRowConstructor["Id_Factura_Garante"] != DBNull.Value)
                {
                    this.Id_Factura_Garante = Convert.ToInt32(DataRowConstructor["Id_Factura_Garante"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura"))
            {
                if (DataRowConstructor["Id_Factura"] != DBNull.Value)
                {
                    this.Id_Factura = Convert.ToInt32(DataRowConstructor["Id_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero"))
            {
                if (DataRowConstructor["Id_Tercero"] != DBNull.Value)
                {
                    this.Id_Tercero = Convert.ToInt32(DataRowConstructor["Id_Tercero"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura_garante</param>
        public Factura_garante(DataSet DataSetConstructor)
        {
            this.ListaFactura_garante = new List<Factura_garante>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura_garante TEMP = new Factura_garante(Fila);
                TEMP.Factura = new Factura(Fila);
                TEMP.Tercero = new Tercero(Fila);
                this.ListaFactura_garante.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura_garante> ListaFactura_garante { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura_Garante { get; set; }
        /// <summary>
        /// id de la factura que va a salir de garantia
        /// </summary>
        public int Id_Factura { get; set; }
        /// <summary>
        /// tercero garante
        /// </summary>
        public int Id_Tercero { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura, Aca van todas las facturas
        /// </summary>
        public Factura Factura { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero, Guarda los cliente y los proveedores
        /// </summary>
        public Tercero Tercero { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura_garante.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura_Garante`, `Id_Factura`, `Id_Tercero` FROM factura_garante " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura_garante.
        /// </summary>
        /// <param name="Id_Factura_Garante">ID de la tabla</param>
        /// <param name="Id_Factura">id de la factura que va a salir de garantia</param>
        /// <param name="Id_Tercero">tercero garante</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura_Garante, int Id_Factura, int Id_Tercero)
        {
            return "INSERT INTO factura_garante(`Id_Factura_Garante`, `Id_Factura`, `Id_Tercero`) VALUES ('" + Id_Factura_Garante.ToString() + "', '" + Id_Factura.ToString() + "', '" + Id_Tercero.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura_garante.
        /// </summary>
        /// <param name="Id_Factura_Garante">ID de la tabla</param>
        /// <param name="Id_Factura">id de la factura que va a salir de garantia</param>
        /// <param name="Id_Tercero">tercero garante</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura_Garante, int Id_Factura, int Id_Tercero, string Filtro)
        {
            return "UPDATE factura_garante SET `Id_Factura_Garante` = '" + Id_Factura_Garante.ToString() + "', `Id_Factura` = '" + Id_Factura.ToString() + "', `Id_Tercero` = '" + Id_Tercero.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_garante.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_garante</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura_garante Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura_garante(`Id_Factura`, `Id_Tercero`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Id_Tercero.ToString() + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Factura_garante.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_garante</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura_garante Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura_garante SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "' WHERE factura_garante.Id_Factura_Garante = " + Obj.Id_Factura_Garante.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Factura_garante.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura_garante WHERE factura_garante.Id_Factura_Garante = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Factura_garante. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_garante</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura_garante Obj)
        {
            if (Common.InsertUpdate("INSERT INTO factura_garante(`Id_Factura`, `Id_Tercero`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Id_Tercero.ToString() + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_garante. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_garante</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura_garante Obj)
        {
            if (Common.InsertUpdate("UPDATE factura_garante SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "' WHERE factura_garante.Id_Factura_Garante = " + Obj.Id_Factura_Garante.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_garante. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura_garante WHERE factura_garante.Id_Factura_Garante = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Asignaciones que se le hacen a las facturas
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:35 a.m.
    /// </summary>
    public partial class Factura_recibo_asignaciones
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura_recibo_asignaciones()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura_recibo_asignaciones</param>
        public Factura_recibo_asignaciones(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Recibo_Asignaciones"))
            {
                if (DataRowConstructor["Id_Factura_Recibo_Asignaciones"] != DBNull.Value)
                {
                    this.Id_Factura_Recibo_Asignaciones = Convert.ToInt32(DataRowConstructor["Id_Factura_Recibo_Asignaciones"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura"))
            {
                if (DataRowConstructor["Id_Factura"] != DBNull.Value)
                {
                    this.Id_Factura = Convert.ToInt32(DataRowConstructor["Id_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Factura_Asignada_Factura_Recibo_Asignaciones"))
            {
                if (DataRowConstructor["Factura_Asignada_Factura_Recibo_Asignaciones"] != DBNull.Value)
                {
                    this.Factura_Asignada_Factura_Recibo_Asignaciones = Convert.ToInt32(DataRowConstructor["Factura_Asignada_Factura_Recibo_Asignaciones"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Impresa_Factura_Recibo_Asignaciones"))
            {
                if (DataRowConstructor["Impresa_Factura_Recibo_Asignaciones"] != DBNull.Value)
                {
                    this.Impresa_Factura_Recibo_Asignaciones = Convert.ToBoolean(DataRowConstructor["Impresa_Factura_Recibo_Asignaciones"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Det1_Factura_Recibo_Asignaciones"))
            {
                if (DataRowConstructor["Det1_Factura_Recibo_Asignaciones"] != DBNull.Value)
                {
                    this.Det1_Factura_Recibo_Asignaciones = DataRowConstructor["Det1_Factura_Recibo_Asignaciones"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Factura_Recibo_Asignaciones"))
            {
                if (DataRowConstructor["Importe_Factura_Recibo_Asignaciones"] != DBNull.Value)
                {
                    this.Importe_Factura_Recibo_Asignaciones = Convert.ToDecimal(DataRowConstructor["Importe_Factura_Recibo_Asignaciones"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Descuento_Factura_Recibo_Asignaciones"))
            {
                if (DataRowConstructor["Importe_Descuento_Factura_Recibo_Asignaciones"] != DBNull.Value)
                {
                    this.Importe_Descuento_Factura_Recibo_Asignaciones = Convert.ToDecimal(DataRowConstructor["Importe_Descuento_Factura_Recibo_Asignaciones"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura_recibo_asignaciones</param>
        public Factura_recibo_asignaciones(DataSet DataSetConstructor)
        {
            this.ListaFactura_recibo_asignaciones = new List<Factura_recibo_asignaciones>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura_recibo_asignaciones TEMP = new Factura_recibo_asignaciones(Fila);
                TEMP.Factura = new Factura(Fila);
                this.ListaFactura_recibo_asignaciones.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura_recibo_asignaciones> ListaFactura_recibo_asignaciones { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura_Recibo_Asignaciones { get; set; }
        /// <summary>
        /// Factura, que seria el recibo u orden de pago a que se le van a asignar facturas
        /// </summary>
        public int Id_Factura { get; set; }
        /// <summary>
        /// factura que se le asigna a esta orden o recibo
        /// </summary>
        public int Factura_Asignada_Factura_Recibo_Asignaciones { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Impresa_Factura_Recibo_Asignaciones { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Det1_Factura_Recibo_Asignaciones { get; set; }
        /// <summary>
        /// Importe de lo que se le va a asignar a esta factura
        /// </summary>
        public decimal Importe_Factura_Recibo_Asignaciones { get; set; }
        /// <summary>
        /// Descuento que tiene esta facturas
        /// </summary>
        public decimal Importe_Descuento_Factura_Recibo_Asignaciones { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura, Aca van todas las facturas
        /// </summary>
        public Factura Factura { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura_recibo_asignaciones.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura_Recibo_Asignaciones`, `Id_Factura`, `Factura_Asignada_Factura_Recibo_Asignaciones`, `Impresa_Factura_Recibo_Asignaciones`, `Det1_Factura_Recibo_Asignaciones`, `Importe_Factura_Recibo_Asignaciones`, `Importe_Descuento_Factura_Recibo_Asignaciones` FROM factura_recibo_asignaciones " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura_recibo_asignaciones.
        /// </summary>
        /// <param name="Id_Factura_Recibo_Asignaciones">ID de la tabla</param>
        /// <param name="Id_Factura">Factura, que seria el recibo u orden de pago a que se le van a asignar facturas</param>
        /// <param name="Factura_Asignada_Factura_Recibo_Asignaciones">factura que se le asigna a esta orden o recibo</param>
        /// <param name="Impresa_Factura_Recibo_Asignaciones"></param>
        /// <param name="Det1_Factura_Recibo_Asignaciones"></param>
        /// <param name="Importe_Factura_Recibo_Asignaciones">Importe de lo que se le va a asignar a esta factura</param>
        /// <param name="Importe_Descuento_Factura_Recibo_Asignaciones">Descuento que tiene esta facturas</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura_Recibo_Asignaciones, int Id_Factura, int Factura_Asignada_Factura_Recibo_Asignaciones, bool Impresa_Factura_Recibo_Asignaciones, string Det1_Factura_Recibo_Asignaciones, decimal Importe_Factura_Recibo_Asignaciones, decimal Importe_Descuento_Factura_Recibo_Asignaciones)
        {
            return "INSERT INTO factura_recibo_asignaciones(`Id_Factura_Recibo_Asignaciones`, `Id_Factura`, `Factura_Asignada_Factura_Recibo_Asignaciones`, `Impresa_Factura_Recibo_Asignaciones`, `Det1_Factura_Recibo_Asignaciones`, `Importe_Factura_Recibo_Asignaciones`, `Importe_Descuento_Factura_Recibo_Asignaciones`) VALUES ('" + Id_Factura_Recibo_Asignaciones.ToString() + "', '" + Id_Factura.ToString() + "', '" + Factura_Asignada_Factura_Recibo_Asignaciones.ToString() + "', '" + Impresa_Factura_Recibo_Asignaciones.ToString() + "', '" + Det1_Factura_Recibo_Asignaciones.ToString() + "', '" + Importe_Factura_Recibo_Asignaciones.ToString() + "', '" + Importe_Descuento_Factura_Recibo_Asignaciones.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura_recibo_asignaciones.
        /// </summary>
        /// <param name="Id_Factura_Recibo_Asignaciones">ID de la tabla</param>
        /// <param name="Id_Factura">Factura, que seria el recibo u orden de pago a que se le van a asignar facturas</param>
        /// <param name="Factura_Asignada_Factura_Recibo_Asignaciones">factura que se le asigna a esta orden o recibo</param>
        /// <param name="Impresa_Factura_Recibo_Asignaciones"></param>
        /// <param name="Det1_Factura_Recibo_Asignaciones"></param>
        /// <param name="Importe_Factura_Recibo_Asignaciones">Importe de lo que se le va a asignar a esta factura</param>
        /// <param name="Importe_Descuento_Factura_Recibo_Asignaciones">Descuento que tiene esta facturas</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura_Recibo_Asignaciones, int Id_Factura, int Factura_Asignada_Factura_Recibo_Asignaciones, bool Impresa_Factura_Recibo_Asignaciones, string Det1_Factura_Recibo_Asignaciones, decimal Importe_Factura_Recibo_Asignaciones, decimal Importe_Descuento_Factura_Recibo_Asignaciones, string Filtro)
        {
            return "UPDATE factura_recibo_asignaciones SET `Id_Factura_Recibo_Asignaciones` = '" + Id_Factura_Recibo_Asignaciones.ToString() + "', `Id_Factura` = '" + Id_Factura.ToString() + "', `Factura_Asignada_Factura_Recibo_Asignaciones` = '" + Factura_Asignada_Factura_Recibo_Asignaciones.ToString() + "', `Impresa_Factura_Recibo_Asignaciones` = '" + Impresa_Factura_Recibo_Asignaciones.ToString() + "', `Det1_Factura_Recibo_Asignaciones` = '" + Det1_Factura_Recibo_Asignaciones.ToString() + "', `Importe_Factura_Recibo_Asignaciones` = '" + Importe_Factura_Recibo_Asignaciones.ToString() + "', `Importe_Descuento_Factura_Recibo_Asignaciones` = '" + Importe_Descuento_Factura_Recibo_Asignaciones.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_recibo_asignaciones.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_asignaciones</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura_recibo_asignaciones Obj)
        {
            if (Obj.Det1_Factura_Recibo_Asignaciones == null)
            {
                throw new Exception("Det1_Factura_Recibo_Asignaciones no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura_recibo_asignaciones(`Id_Factura`, `Factura_Asignada_Factura_Recibo_Asignaciones`, `Impresa_Factura_Recibo_Asignaciones`, `Det1_Factura_Recibo_Asignaciones`, `Importe_Factura_Recibo_Asignaciones`, `Importe_Descuento_Factura_Recibo_Asignaciones`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Factura_Asignada_Factura_Recibo_Asignaciones.ToString() + "', " + Common.BoolToString(Obj.Impresa_Factura_Recibo_Asignaciones) + ", " + "'" + Obj.Det1_Factura_Recibo_Asignaciones + "', " + "'" + Obj.Importe_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "', " + "'" + Obj.Importe_Descuento_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Factura_recibo_asignaciones.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_asignaciones</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura_recibo_asignaciones Obj)
        {
            if (Obj.Det1_Factura_Recibo_Asignaciones == null)
            {
                throw new Exception("Det1_Factura_Recibo_Asignaciones no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura_recibo_asignaciones SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Factura_Asignada_Factura_Recibo_Asignaciones` =  '" + Obj.Factura_Asignada_Factura_Recibo_Asignaciones.ToString() + "', `Impresa_Factura_Recibo_Asignaciones` = " + Common.BoolToString(Obj.Impresa_Factura_Recibo_Asignaciones) + ", `Det1_Factura_Recibo_Asignaciones` =  '" + Obj.Det1_Factura_Recibo_Asignaciones + "', `Importe_Factura_Recibo_Asignaciones` =  '" + Obj.Importe_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "', `Importe_Descuento_Factura_Recibo_Asignaciones` =  '" + Obj.Importe_Descuento_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "' WHERE factura_recibo_asignaciones.Id_Factura_Recibo_Asignaciones = " + Obj.Id_Factura_Recibo_Asignaciones.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Factura_recibo_asignaciones.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura_recibo_asignaciones WHERE factura_recibo_asignaciones.Id_Factura_Recibo_Asignaciones = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Factura_recibo_asignaciones. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_asignaciones</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura_recibo_asignaciones Obj)
        {
            if (Obj.Det1_Factura_Recibo_Asignaciones == null)
            {
                throw new Exception("Det1_Factura_Recibo_Asignaciones no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO factura_recibo_asignaciones(`Id_Factura`, `Factura_Asignada_Factura_Recibo_Asignaciones`, `Impresa_Factura_Recibo_Asignaciones`, `Det1_Factura_Recibo_Asignaciones`, `Importe_Factura_Recibo_Asignaciones`, `Importe_Descuento_Factura_Recibo_Asignaciones`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Factura_Asignada_Factura_Recibo_Asignaciones.ToString() + "', " + Common.BoolToString(Obj.Impresa_Factura_Recibo_Asignaciones) + ", " + "'" + Obj.Det1_Factura_Recibo_Asignaciones + "', " + "'" + Obj.Importe_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "', " + "'" + Obj.Importe_Descuento_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_recibo_asignaciones. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_asignaciones</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura_recibo_asignaciones Obj)
        {
            if (Obj.Det1_Factura_Recibo_Asignaciones == null)
            {
                throw new Exception("Det1_Factura_Recibo_Asignaciones no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE factura_recibo_asignaciones SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Factura_Asignada_Factura_Recibo_Asignaciones` =  '" + Obj.Factura_Asignada_Factura_Recibo_Asignaciones.ToString() + "', `Impresa_Factura_Recibo_Asignaciones` = " + Common.BoolToString(Obj.Impresa_Factura_Recibo_Asignaciones) + ", `Det1_Factura_Recibo_Asignaciones` =  '" + Obj.Det1_Factura_Recibo_Asignaciones + "', `Importe_Factura_Recibo_Asignaciones` =  '" + Obj.Importe_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "', `Importe_Descuento_Factura_Recibo_Asignaciones` =  '" + Obj.Importe_Descuento_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "' WHERE factura_recibo_asignaciones.Id_Factura_Recibo_Asignaciones = " + Obj.Id_Factura_Recibo_Asignaciones.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_recibo_asignaciones. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura_recibo_asignaciones WHERE factura_recibo_asignaciones.Id_Factura_Recibo_Asignaciones = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Detalle de los recibo y ordenes
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:35 a.m.
    /// </summary>
    public partial class Factura_recibo_detalle
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura_recibo_detalle()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura_recibo_detalle</param>
        public Factura_recibo_detalle(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Recibo_Detalle"))
            {
                if (DataRowConstructor["Id_Factura_Recibo_Detalle"] != DBNull.Value)
                {
                    this.Id_Factura_Recibo_Detalle = Convert.ToInt32(DataRowConstructor["Id_Factura_Recibo_Detalle"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura"))
            {
                if (DataRowConstructor["Id_Factura"] != DBNull.Value)
                {
                    this.Id_Factura = Convert.ToInt32(DataRowConstructor["Id_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Recibo_Tipo"))
            {
                if (DataRowConstructor["Id_Factura_Recibo_Tipo"] != DBNull.Value)
                {
                    this.Id_Factura_Recibo_Tipo = Convert.ToInt32(DataRowConstructor["Id_Factura_Recibo_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Factura_Recibo_Detalle"))
            {
                if (DataRowConstructor["Importe_Factura_Recibo_Detalle"] != DBNull.Value)
                {
                    this.Importe_Factura_Recibo_Detalle = Convert.ToDecimal(DataRowConstructor["Importe_Factura_Recibo_Detalle"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Descuento_Factura_Recibo_Detalle"))
            {
                if (DataRowConstructor["Importe_Descuento_Factura_Recibo_Detalle"] != DBNull.Value)
                {
                    this.Importe_Descuento_Factura_Recibo_Detalle = Convert.ToDecimal(DataRowConstructor["Importe_Descuento_Factura_Recibo_Detalle"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura_recibo_detalle</param>
        public Factura_recibo_detalle(DataSet DataSetConstructor)
        {
            this.ListaFactura_recibo_detalle = new List<Factura_recibo_detalle>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura_recibo_detalle TEMP = new Factura_recibo_detalle(Fila);
                TEMP.Factura = new Factura(Fila);
                TEMP.Factura_recibo_tipo = new Factura_recibo_tipo(Fila);
                this.ListaFactura_recibo_detalle.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura_recibo_detalle> ListaFactura_recibo_detalle { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura_Recibo_Detalle { get; set; }
        /// <summary>
        /// Id de la orden de pago o recibo
        /// </summary>
        public int Id_Factura { get; set; }
        /// <summary>
        /// Tipo asignacion a este recibo u orden
        /// </summary>
        public int Id_Factura_Recibo_Tipo { get; set; }
        /// <summary>
        /// Importe de la asignacion
        /// </summary>
        public decimal Importe_Factura_Recibo_Detalle { get; set; }
        /// <summary>
        /// Algun descuento a la asignacion
        /// </summary>
        public decimal Importe_Descuento_Factura_Recibo_Detalle { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura, Aca van todas las facturas
        /// </summary>
        public Factura Factura { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura_recibo_tipo, Tipo de pagos en recibos
        /// </summary>
        public Factura_recibo_tipo Factura_recibo_tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura_recibo_detalle.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura_Recibo_Detalle`, `Id_Factura`, `Id_Factura_Recibo_Tipo`, `Importe_Factura_Recibo_Detalle`, `Importe_Descuento_Factura_Recibo_Detalle` FROM factura_recibo_detalle " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura_recibo_detalle.
        /// </summary>
        /// <param name="Id_Factura_Recibo_Detalle">ID de la tabla</param>
        /// <param name="Id_Factura">Id de la orden de pago o recibo</param>
        /// <param name="Id_Factura_Recibo_Tipo">Tipo asignacion a este recibo u orden</param>
        /// <param name="Importe_Factura_Recibo_Detalle">Importe de la asignacion</param>
        /// <param name="Importe_Descuento_Factura_Recibo_Detalle">Algun descuento a la asignacion</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura_Recibo_Detalle, int Id_Factura, int Id_Factura_Recibo_Tipo, decimal Importe_Factura_Recibo_Detalle, decimal Importe_Descuento_Factura_Recibo_Detalle)
        {
            return "INSERT INTO factura_recibo_detalle(`Id_Factura_Recibo_Detalle`, `Id_Factura`, `Id_Factura_Recibo_Tipo`, `Importe_Factura_Recibo_Detalle`, `Importe_Descuento_Factura_Recibo_Detalle`) VALUES ('" + Id_Factura_Recibo_Detalle.ToString() + "', '" + Id_Factura.ToString() + "', '" + Id_Factura_Recibo_Tipo.ToString() + "', '" + Importe_Factura_Recibo_Detalle.ToString() + "', '" + Importe_Descuento_Factura_Recibo_Detalle.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura_recibo_detalle.
        /// </summary>
        /// <param name="Id_Factura_Recibo_Detalle">ID de la tabla</param>
        /// <param name="Id_Factura">Id de la orden de pago o recibo</param>
        /// <param name="Id_Factura_Recibo_Tipo">Tipo asignacion a este recibo u orden</param>
        /// <param name="Importe_Factura_Recibo_Detalle">Importe de la asignacion</param>
        /// <param name="Importe_Descuento_Factura_Recibo_Detalle">Algun descuento a la asignacion</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura_Recibo_Detalle, int Id_Factura, int Id_Factura_Recibo_Tipo, decimal Importe_Factura_Recibo_Detalle, decimal Importe_Descuento_Factura_Recibo_Detalle, string Filtro)
        {
            return "UPDATE factura_recibo_detalle SET `Id_Factura_Recibo_Detalle` = '" + Id_Factura_Recibo_Detalle.ToString() + "', `Id_Factura` = '" + Id_Factura.ToString() + "', `Id_Factura_Recibo_Tipo` = '" + Id_Factura_Recibo_Tipo.ToString() + "', `Importe_Factura_Recibo_Detalle` = '" + Importe_Factura_Recibo_Detalle.ToString() + "', `Importe_Descuento_Factura_Recibo_Detalle` = '" + Importe_Descuento_Factura_Recibo_Detalle.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_recibo_detalle.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura_recibo_detalle Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura_recibo_detalle(`Id_Factura`, `Id_Factura_Recibo_Tipo`, `Importe_Factura_Recibo_Detalle`, `Importe_Descuento_Factura_Recibo_Detalle`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Id_Factura_Recibo_Tipo.ToString() + "', " + "'" + Obj.Importe_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "', " + "'" + Obj.Importe_Descuento_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Factura_recibo_detalle.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura_recibo_detalle Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura_recibo_detalle SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Id_Factura_Recibo_Tipo` =  '" + Obj.Id_Factura_Recibo_Tipo.ToString() + "', `Importe_Factura_Recibo_Detalle` =  '" + Obj.Importe_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "', `Importe_Descuento_Factura_Recibo_Detalle` =  '" + Obj.Importe_Descuento_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "' WHERE factura_recibo_detalle.Id_Factura_Recibo_Detalle = " + Obj.Id_Factura_Recibo_Detalle.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Factura_recibo_detalle.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura_recibo_detalle WHERE factura_recibo_detalle.Id_Factura_Recibo_Detalle = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Factura_recibo_detalle. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura_recibo_detalle Obj)
        {
            if (Common.InsertUpdate("INSERT INTO factura_recibo_detalle(`Id_Factura`, `Id_Factura_Recibo_Tipo`, `Importe_Factura_Recibo_Detalle`, `Importe_Descuento_Factura_Recibo_Detalle`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Id_Factura_Recibo_Tipo.ToString() + "', " + "'" + Obj.Importe_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "', " + "'" + Obj.Importe_Descuento_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_recibo_detalle. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura_recibo_detalle Obj)
        {
            if (Common.InsertUpdate("UPDATE factura_recibo_detalle SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Id_Factura_Recibo_Tipo` =  '" + Obj.Id_Factura_Recibo_Tipo.ToString() + "', `Importe_Factura_Recibo_Detalle` =  '" + Obj.Importe_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "', `Importe_Descuento_Factura_Recibo_Detalle` =  '" + Obj.Importe_Descuento_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "' WHERE factura_recibo_detalle.Id_Factura_Recibo_Detalle = " + Obj.Id_Factura_Recibo_Detalle.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_recibo_detalle. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura_recibo_detalle WHERE factura_recibo_detalle.Id_Factura_Recibo_Detalle = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Tipo de pagos en recibos
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:35 a.m.
    /// </summary>
    public partial class Factura_recibo_tipo
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura_recibo_tipo()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura_recibo_tipo</param>
        public Factura_recibo_tipo(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Recibo_Tipo"))
            {
                if (DataRowConstructor["Id_Factura_Recibo_Tipo"] != DBNull.Value)
                {
                    this.Id_Factura_Recibo_Tipo = Convert.ToInt32(DataRowConstructor["Id_Factura_Recibo_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Factura_Recibo_Tipo"))
            {
                if (DataRowConstructor["Descripcion_Factura_Recibo_Tipo"] != DBNull.Value)
                {
                    this.Descripcion_Factura_Recibo_Tipo = DataRowConstructor["Descripcion_Factura_Recibo_Tipo"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura_recibo_tipo</param>
        public Factura_recibo_tipo(DataSet DataSetConstructor)
        {
            this.ListaFactura_recibo_tipo = new List<Factura_recibo_tipo>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura_recibo_tipo TEMP = new Factura_recibo_tipo(Fila);
                this.ListaFactura_recibo_tipo.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura_recibo_tipo> ListaFactura_recibo_tipo { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura_Recibo_Tipo { get; set; }
        /// <summary>
        /// Descripcion del tipo de recibo, es la forma de pago
        /// </summary>
        public string Descripcion_Factura_Recibo_Tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura_recibo_tipo.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura_Recibo_Tipo`, `Descripcion_Factura_Recibo_Tipo` FROM factura_recibo_tipo " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura_recibo_tipo.
        /// </summary>
        /// <param name="Id_Factura_Recibo_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Factura_Recibo_Tipo">Descripcion del tipo de recibo, es la forma de pago</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura_Recibo_Tipo, string Descripcion_Factura_Recibo_Tipo)
        {
            return "INSERT INTO factura_recibo_tipo(`Id_Factura_Recibo_Tipo`, `Descripcion_Factura_Recibo_Tipo`) VALUES ('" + Id_Factura_Recibo_Tipo.ToString() + "', '" + Descripcion_Factura_Recibo_Tipo.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura_recibo_tipo.
        /// </summary>
        /// <param name="Id_Factura_Recibo_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Factura_Recibo_Tipo">Descripcion del tipo de recibo, es la forma de pago</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura_Recibo_Tipo, string Descripcion_Factura_Recibo_Tipo, string Filtro)
        {
            return "UPDATE factura_recibo_tipo SET `Id_Factura_Recibo_Tipo` = '" + Id_Factura_Recibo_Tipo.ToString() + "', `Descripcion_Factura_Recibo_Tipo` = '" + Descripcion_Factura_Recibo_Tipo.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_recibo_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura_recibo_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Recibo_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Recibo_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura_recibo_tipo(`Descripcion_Factura_Recibo_Tipo`)VALUES( " + "'" + Obj.Descripcion_Factura_Recibo_Tipo + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Factura_recibo_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura_recibo_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Recibo_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Recibo_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura_recibo_tipo SET `Descripcion_Factura_Recibo_Tipo` =  '" + Obj.Descripcion_Factura_Recibo_Tipo + "' WHERE factura_recibo_tipo.Id_Factura_Recibo_Tipo = " + Obj.Id_Factura_Recibo_Tipo.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Factura_recibo_tipo.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura_recibo_tipo WHERE factura_recibo_tipo.Id_Factura_Recibo_Tipo = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Factura_recibo_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura_recibo_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Recibo_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Recibo_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO factura_recibo_tipo(`Descripcion_Factura_Recibo_Tipo`)VALUES( " + "'" + Obj.Descripcion_Factura_Recibo_Tipo + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_recibo_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura_recibo_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Recibo_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Recibo_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE factura_recibo_tipo SET `Descripcion_Factura_Recibo_Tipo` =  '" + Obj.Descripcion_Factura_Recibo_Tipo + "' WHERE factura_recibo_tipo.Id_Factura_Recibo_Tipo = " + Obj.Id_Factura_Recibo_Tipo.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_recibo_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura_recibo_tipo WHERE factura_recibo_tipo.Id_Factura_Recibo_Tipo = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Tipo de comprobantes
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:35 a.m.
    /// </summary>
    public partial class Factura_tipo
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura_tipo()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura_tipo</param>
        public Factura_tipo(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Tipo"))
            {
                if (DataRowConstructor["Id_Factura_Tipo"] != DBNull.Value)
                {
                    this.Id_Factura_Tipo = Convert.ToInt32(DataRowConstructor["Id_Factura_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Factura_Tipo"))
            {
                if (DataRowConstructor["Descripcion_Factura_Tipo"] != DBNull.Value)
                {
                    this.Descripcion_Factura_Tipo = DataRowConstructor["Descripcion_Factura_Tipo"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Abreviacion_Factura_Tipo"))
            {
                if (DataRowConstructor["Abreviacion_Factura_Tipo"] != DBNull.Value)
                {
                    this.Abreviacion_Factura_Tipo = DataRowConstructor["Abreviacion_Factura_Tipo"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura_tipo</param>
        public Factura_tipo(DataSet DataSetConstructor)
        {
            this.ListaFactura_tipo = new List<Factura_tipo>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura_tipo TEMP = new Factura_tipo(Fila);
                this.ListaFactura_tipo.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura_tipo> ListaFactura_tipo { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura_Tipo { get; set; }
        /// <summary>
        /// Descripcion del tipo de factura
        /// </summary>
        public string Descripcion_Factura_Tipo { get; set; }
        /// <summary>
        /// Abreviatura del tipo de factura
        /// </summary>
        public string Abreviacion_Factura_Tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura_tipo.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura_Tipo`, `Descripcion_Factura_Tipo`, `Abreviacion_Factura_Tipo` FROM factura_tipo " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura_tipo.
        /// </summary>
        /// <param name="Id_Factura_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Factura_Tipo">Descripcion del tipo de factura</param>
        /// <param name="Abreviacion_Factura_Tipo">Abreviatura del tipo de factura</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura_Tipo, string Descripcion_Factura_Tipo, string Abreviacion_Factura_Tipo)
        {
            return "INSERT INTO factura_tipo(`Id_Factura_Tipo`, `Descripcion_Factura_Tipo`, `Abreviacion_Factura_Tipo`) VALUES ('" + Id_Factura_Tipo.ToString() + "', '" + Descripcion_Factura_Tipo.ToString() + "', '" + Abreviacion_Factura_Tipo.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura_tipo.
        /// </summary>
        /// <param name="Id_Factura_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Factura_Tipo">Descripcion del tipo de factura</param>
        /// <param name="Abreviacion_Factura_Tipo">Abreviatura del tipo de factura</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura_Tipo, string Descripcion_Factura_Tipo, string Abreviacion_Factura_Tipo, string Filtro)
        {
            return "UPDATE factura_tipo SET `Id_Factura_Tipo` = '" + Id_Factura_Tipo.ToString() + "', `Descripcion_Factura_Tipo` = '" + Descripcion_Factura_Tipo.ToString() + "', `Abreviacion_Factura_Tipo` = '" + Abreviacion_Factura_Tipo.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Tipo no puede ser null");
            }
            if (Obj.Abreviacion_Factura_Tipo == null)
            {
                throw new Exception("Abreviacion_Factura_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura_tipo(`Descripcion_Factura_Tipo`, `Abreviacion_Factura_Tipo`)VALUES( " + "'" + Obj.Descripcion_Factura_Tipo + "', " + "'" + Obj.Abreviacion_Factura_Tipo + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Factura_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Tipo no puede ser null");
            }
            if (Obj.Abreviacion_Factura_Tipo == null)
            {
                throw new Exception("Abreviacion_Factura_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura_tipo SET `Descripcion_Factura_Tipo` =  '" + Obj.Descripcion_Factura_Tipo + "', `Abreviacion_Factura_Tipo` =  '" + Obj.Abreviacion_Factura_Tipo + "' WHERE factura_tipo.Id_Factura_Tipo = " + Obj.Id_Factura_Tipo.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Factura_tipo.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura_tipo WHERE factura_tipo.Id_Factura_Tipo = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Factura_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Tipo no puede ser null");
            }
            if (Obj.Abreviacion_Factura_Tipo == null)
            {
                throw new Exception("Abreviacion_Factura_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO factura_tipo(`Descripcion_Factura_Tipo`, `Abreviacion_Factura_Tipo`)VALUES( " + "'" + Obj.Descripcion_Factura_Tipo + "', " + "'" + Obj.Abreviacion_Factura_Tipo + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Tipo no puede ser null");
            }
            if (Obj.Abreviacion_Factura_Tipo == null)
            {
                throw new Exception("Abreviacion_Factura_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE factura_tipo SET `Descripcion_Factura_Tipo` =  '" + Obj.Descripcion_Factura_Tipo + "', `Abreviacion_Factura_Tipo` =  '" + Obj.Abreviacion_Factura_Tipo + "' WHERE factura_tipo.Id_Factura_Tipo = " + Obj.Id_Factura_Tipo.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura_tipo WHERE factura_tipo.Id_Factura_Tipo = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Contiene todas las modificaciones que se hace en la base de 
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:35 a.m.
    /// </summary>
    public partial class Historial_sql
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Historial_sql()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Historial_sql</param>
        public Historial_sql(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Historial_SQL"))
            {
                if (DataRowConstructor["Id_Historial_SQL"] != DBNull.Value)
                {
                    this.Id_Historial_SQL = Convert.ToInt32(DataRowConstructor["Id_Historial_SQL"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("SQL_Historial_SQL"))
            {
                if (DataRowConstructor["SQL_Historial_SQL"] != DBNull.Value)
                {
                    this.SQL_Historial_SQL = DataRowConstructor["SQL_Historial_SQL"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Historial_SQL"))
            {
                if (DataRowConstructor["Fecha_Historial_SQL"] != DBNull.Value)
                {
                    this.Fecha_Historial_SQL = Convert.ToDateTime(DataRowConstructor["Fecha_Historial_SQL"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("IP_Historial_SQL"))
            {
                if (DataRowConstructor["IP_Historial_SQL"] != DBNull.Value)
                {
                    this.IP_Historial_SQL = DataRowConstructor["IP_Historial_SQL"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Historial_sql</param>
        public Historial_sql(DataSet DataSetConstructor)
        {
            this.ListaHistorial_sql = new List<Historial_sql>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Historial_sql TEMP = new Historial_sql(Fila);
                this.ListaHistorial_sql.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Historial_sql> ListaHistorial_sql { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Historial_SQL { get; set; }
        /// <summary>
        /// SQL que modifica la base de datos
        /// </summary>
        public string SQL_Historial_SQL { get; set; }
        /// <summary>
        /// Fecha y hora en que se ejecula la SQL
        /// </summary>
        public DateTime Fecha_Historial_SQL { get; set; }
        /// <summary>
        /// IP de donde biene el SQL
        /// </summary>
        public string IP_Historial_SQL { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla historial_sql.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Historial_SQL`, `SQL_Historial_SQL`, `Fecha_Historial_SQL`, `IP_Historial_SQL` FROM historial_sql " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla historial_sql.
        /// </summary>
        /// <param name="Id_Historial_SQL">ID de la tabla</param>
        /// <param name="SQL_Historial_SQL">SQL que modifica la base de datos</param>
        /// <param name="Fecha_Historial_SQL">Fecha y hora en que se ejecula la SQL</param>
        /// <param name="IP_Historial_SQL">IP de donde biene el SQL</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Historial_SQL, string SQL_Historial_SQL, DateTime Fecha_Historial_SQL, string IP_Historial_SQL)
        {
            return "INSERT INTO historial_sql(`Id_Historial_SQL`, `SQL_Historial_SQL`, `Fecha_Historial_SQL`, `IP_Historial_SQL`) VALUES ('" + Id_Historial_SQL.ToString() + "', '" + SQL_Historial_SQL.ToString() + "', '" + Fecha_Historial_SQL.ToString() + "', '" + IP_Historial_SQL.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla historial_sql.
        /// </summary>
        /// <param name="Id_Historial_SQL">ID de la tabla</param>
        /// <param name="SQL_Historial_SQL">SQL que modifica la base de datos</param>
        /// <param name="Fecha_Historial_SQL">Fecha y hora en que se ejecula la SQL</param>
        /// <param name="IP_Historial_SQL">IP de donde biene el SQL</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Historial_SQL, string SQL_Historial_SQL, DateTime Fecha_Historial_SQL, string IP_Historial_SQL, string Filtro)
        {
            return "UPDATE historial_sql SET `Id_Historial_SQL` = '" + Id_Historial_SQL.ToString() + "', `SQL_Historial_SQL` = '" + SQL_Historial_SQL.ToString() + "', `Fecha_Historial_SQL` = '" + Fecha_Historial_SQL.ToString() + "', `IP_Historial_SQL` = '" + IP_Historial_SQL.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Historial_sql.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Historial_sql</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Historial_sql Obj)
        {
            if (Obj.SQL_Historial_SQL == null)
            {
                throw new Exception("SQL_Historial_SQL no puede ser null");
            }
            if (Obj.Fecha_Historial_SQL == null)
            {
                throw new Exception("Fecha_Historial_SQL no puede ser null");
            }
            if (Obj.IP_Historial_SQL == null)
            {
                throw new Exception("IP_Historial_SQL no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO historial_sql(`SQL_Historial_SQL`, `Fecha_Historial_SQL`, `IP_Historial_SQL`)VALUES( " + "'" + Obj.SQL_Historial_SQL + "', " + "'" + Obj.Fecha_Historial_SQL.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.IP_Historial_SQL + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Historial_sql.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Historial_sql</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Historial_sql Obj)
        {
            if (Obj.SQL_Historial_SQL == null)
            {
                throw new Exception("SQL_Historial_SQL no puede ser null");
            }
            if (Obj.Fecha_Historial_SQL == null)
            {
                throw new Exception("Fecha_Historial_SQL no puede ser null");
            }
            if (Obj.IP_Historial_SQL == null)
            {
                throw new Exception("IP_Historial_SQL no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE historial_sql SET `SQL_Historial_SQL` =  '" + Obj.SQL_Historial_SQL + "', `Fecha_Historial_SQL` =  '" + Obj.Fecha_Historial_SQL.ToString("yyyy-MM-dd HH:mm:ss") + "', `IP_Historial_SQL` =  '" + Obj.IP_Historial_SQL + "' WHERE historial_sql.Id_Historial_SQL = " + Obj.Id_Historial_SQL.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Historial_sql.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM historial_sql WHERE historial_sql.Id_Historial_SQL = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Historial_sql. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Historial_sql</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Historial_sql Obj)
        {
            if (Obj.SQL_Historial_SQL == null)
            {
                throw new Exception("SQL_Historial_SQL no puede ser null");
            }
            if (Obj.Fecha_Historial_SQL == null)
            {
                throw new Exception("Fecha_Historial_SQL no puede ser null");
            }
            if (Obj.IP_Historial_SQL == null)
            {
                throw new Exception("IP_Historial_SQL no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO historial_sql(`SQL_Historial_SQL`, `Fecha_Historial_SQL`, `IP_Historial_SQL`)VALUES( " + "'" + Obj.SQL_Historial_SQL + "', " + "'" + Obj.Fecha_Historial_SQL.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.IP_Historial_SQL + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Historial_sql. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Historial_sql</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Historial_sql Obj)
        {
            if (Obj.SQL_Historial_SQL == null)
            {
                throw new Exception("SQL_Historial_SQL no puede ser null");
            }
            if (Obj.Fecha_Historial_SQL == null)
            {
                throw new Exception("Fecha_Historial_SQL no puede ser null");
            }
            if (Obj.IP_Historial_SQL == null)
            {
                throw new Exception("IP_Historial_SQL no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE historial_sql SET `SQL_Historial_SQL` =  '" + Obj.SQL_Historial_SQL + "', `Fecha_Historial_SQL` =  '" + Obj.Fecha_Historial_SQL.ToString("yyyy-MM-dd HH:mm:ss") + "', `IP_Historial_SQL` =  '" + Obj.IP_Historial_SQL + "' WHERE historial_sql.Id_Historial_SQL = " + Obj.Id_Historial_SQL.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Historial_sql. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM historial_sql WHERE historial_sql.Id_Historial_SQL = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Linea de los articulos
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:36 a.m.
    /// </summary>
    public partial class Linea
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Linea()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Linea</param>
        public Linea(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Linea"))
            {
                if (DataRowConstructor["Id_Linea"] != DBNull.Value)
                {
                    this.Id_Linea = Convert.ToInt32(DataRowConstructor["Id_Linea"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Linea"))
            {
                if (DataRowConstructor["Descripcion_Linea"] != DBNull.Value)
                {
                    this.Descripcion_Linea = DataRowConstructor["Descripcion_Linea"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Linea</param>
        public Linea(DataSet DataSetConstructor)
        {
            this.ListaLinea = new List<Linea>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Linea TEMP = new Linea(Fila);
                this.ListaLinea.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Linea> ListaLinea { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Linea { get; set; }
        /// <summary>
        /// Descripcion de la linea
        /// </summary>
        public string Descripcion_Linea { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla linea.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Linea`, `Descripcion_Linea` FROM linea " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla linea.
        /// </summary>
        /// <param name="Id_Linea">ID de la tabla</param>
        /// <param name="Descripcion_Linea">Descripcion de la linea</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Linea, string Descripcion_Linea)
        {
            return "INSERT INTO linea(`Id_Linea`, `Descripcion_Linea`) VALUES ('" + Id_Linea.ToString() + "', '" + Descripcion_Linea.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla linea.
        /// </summary>
        /// <param name="Id_Linea">ID de la tabla</param>
        /// <param name="Descripcion_Linea">Descripcion de la linea</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Linea, string Descripcion_Linea, string Filtro)
        {
            return "UPDATE linea SET `Id_Linea` = '" + Id_Linea.ToString() + "', `Descripcion_Linea` = '" + Descripcion_Linea.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Linea.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Linea</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Linea Obj)
        {
            if (Obj.Descripcion_Linea == null)
            {
                throw new Exception("Descripcion_Linea no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO linea(`Descripcion_Linea`)VALUES( " + "'" + Obj.Descripcion_Linea + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Linea.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Linea</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Linea Obj)
        {
            if (Obj.Descripcion_Linea == null)
            {
                throw new Exception("Descripcion_Linea no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE linea SET `Descripcion_Linea` =  '" + Obj.Descripcion_Linea + "' WHERE linea.Id_Linea = " + Obj.Id_Linea.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Linea.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM linea WHERE linea.Id_Linea = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Linea. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Linea</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Linea Obj)
        {
            if (Obj.Descripcion_Linea == null)
            {
                throw new Exception("Descripcion_Linea no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO linea(`Descripcion_Linea`)VALUES( " + "'" + Obj.Descripcion_Linea + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Linea. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Linea</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Linea Obj)
        {
            if (Obj.Descripcion_Linea == null)
            {
                throw new Exception("Descripcion_Linea no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE linea SET `Descripcion_Linea` =  '" + Obj.Descripcion_Linea + "' WHERE linea.Id_Linea = " + Obj.Id_Linea.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Linea. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM linea WHERE linea.Id_Linea = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Ciudades del sistema
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:36 a.m.
    /// </summary>
    public partial class Localidad
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Localidad()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Localidad</param>
        public Localidad(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Localidad"))
            {
                if (DataRowConstructor["Id_Localidad"] != DBNull.Value)
                {
                    this.Id_Localidad = Convert.ToInt32(DataRowConstructor["Id_Localidad"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Provincia"))
            {
                if (DataRowConstructor["Id_Provincia"] != DBNull.Value)
                {
                    this.Id_Provincia = Convert.ToInt32(DataRowConstructor["Id_Provincia"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Nombre_Localidad"))
            {
                if (DataRowConstructor["Nombre_Localidad"] != DBNull.Value)
                {
                    this.Nombre_Localidad = DataRowConstructor["Nombre_Localidad"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Codigo_Postal_Localidad"))
            {
                if (DataRowConstructor["Codigo_Postal_Localidad"] != DBNull.Value)
                {
                    this.Codigo_Postal_Localidad = Convert.ToInt32(DataRowConstructor["Codigo_Postal_Localidad"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Localidad</param>
        public Localidad(DataSet DataSetConstructor)
        {
            this.ListaLocalidad = new List<Localidad>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Localidad TEMP = new Localidad(Fila);
                TEMP.Provincia = new Provincia(Fila);
                this.ListaLocalidad.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Localidad> ListaLocalidad { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Localidad { get; set; }
        /// <summary>
        /// ID de la provincia
        /// </summary>
        public int Id_Provincia { get; set; }
        /// <summary>
        /// Nombre de la localidad
        /// </summary>
        public string Nombre_Localidad { get; set; }
        /// <summary>
        /// Codigo postal de la localidad
        /// </summary>
        public int Codigo_Postal_Localidad { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Provincia, Provincias del sistema
        /// </summary>
        public Provincia Provincia { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla localidad.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Localidad`, `Id_Provincia`, `Nombre_Localidad`, `Codigo_Postal_Localidad` FROM localidad " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla localidad.
        /// </summary>
        /// <param name="Id_Localidad">ID de la tabla</param>
        /// <param name="Id_Provincia">ID de la provincia</param>
        /// <param name="Nombre_Localidad">Nombre de la localidad</param>
        /// <param name="Codigo_Postal_Localidad">Codigo postal de la localidad</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Localidad, int Id_Provincia, string Nombre_Localidad, int Codigo_Postal_Localidad)
        {
            return "INSERT INTO localidad(`Id_Localidad`, `Id_Provincia`, `Nombre_Localidad`, `Codigo_Postal_Localidad`) VALUES ('" + Id_Localidad.ToString() + "', '" + Id_Provincia.ToString() + "', '" + Nombre_Localidad.ToString() + "', '" + Codigo_Postal_Localidad.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla localidad.
        /// </summary>
        /// <param name="Id_Localidad">ID de la tabla</param>
        /// <param name="Id_Provincia">ID de la provincia</param>
        /// <param name="Nombre_Localidad">Nombre de la localidad</param>
        /// <param name="Codigo_Postal_Localidad">Codigo postal de la localidad</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Localidad, int Id_Provincia, string Nombre_Localidad, int Codigo_Postal_Localidad, string Filtro)
        {
            return "UPDATE localidad SET `Id_Localidad` = '" + Id_Localidad.ToString() + "', `Id_Provincia` = '" + Id_Provincia.ToString() + "', `Nombre_Localidad` = '" + Nombre_Localidad.ToString() + "', `Codigo_Postal_Localidad` = '" + Codigo_Postal_Localidad.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Localidad.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Localidad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Localidad Obj)
        {
            if (Obj.Nombre_Localidad == null)
            {
                throw new Exception("Nombre_Localidad no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO localidad(`Id_Provincia`, `Nombre_Localidad`, `Codigo_Postal_Localidad`)VALUES( " + "'" + Obj.Id_Provincia.ToString() + "', " + "'" + Obj.Nombre_Localidad + "', " + "'" + Obj.Codigo_Postal_Localidad.ToString() + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Localidad.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Localidad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Localidad Obj)
        {
            if (Obj.Nombre_Localidad == null)
            {
                throw new Exception("Nombre_Localidad no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE localidad SET `Id_Provincia` =  '" + Obj.Id_Provincia.ToString() + "', `Nombre_Localidad` =  '" + Obj.Nombre_Localidad + "', `Codigo_Postal_Localidad` =  '" + Obj.Codigo_Postal_Localidad.ToString() + "' WHERE localidad.Id_Localidad = " + Obj.Id_Localidad.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Localidad.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM localidad WHERE localidad.Id_Localidad = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Localidad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Localidad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Localidad Obj)
        {
            if (Obj.Nombre_Localidad == null)
            {
                throw new Exception("Nombre_Localidad no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO localidad(`Id_Provincia`, `Nombre_Localidad`, `Codigo_Postal_Localidad`)VALUES( " + "'" + Obj.Id_Provincia.ToString() + "', " + "'" + Obj.Nombre_Localidad + "', " + "'" + Obj.Codigo_Postal_Localidad.ToString() + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Localidad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Localidad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Localidad Obj)
        {
            if (Obj.Nombre_Localidad == null)
            {
                throw new Exception("Nombre_Localidad no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE localidad SET `Id_Provincia` =  '" + Obj.Id_Provincia.ToString() + "', `Nombre_Localidad` =  '" + Obj.Nombre_Localidad + "', `Codigo_Postal_Localidad` =  '" + Obj.Codigo_Postal_Localidad.ToString() + "' WHERE localidad.Id_Localidad = " + Obj.Id_Localidad.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Localidad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM localidad WHERE localidad.Id_Localidad = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Paises del sistema
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:36 a.m.
    /// </summary>
    public partial class Pais
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Pais()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Pais</param>
        public Pais(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Pais"))
            {
                if (DataRowConstructor["Id_Pais"] != DBNull.Value)
                {
                    this.Id_Pais = Convert.ToInt32(DataRowConstructor["Id_Pais"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Nombre_Pais"))
            {
                if (DataRowConstructor["Nombre_Pais"] != DBNull.Value)
                {
                    this.Nombre_Pais = DataRowConstructor["Nombre_Pais"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Pais</param>
        public Pais(DataSet DataSetConstructor)
        {
            this.ListaPais = new List<Pais>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Pais TEMP = new Pais(Fila);
                this.ListaPais.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Pais> ListaPais { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Pais { get; set; }
        /// <summary>
        /// Nombre del pais
        /// </summary>
        public string Nombre_Pais { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla pais.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Pais`, `Nombre_Pais` FROM pais " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla pais.
        /// </summary>
        /// <param name="Id_Pais">ID de la tabla</param>
        /// <param name="Nombre_Pais">Nombre del pais</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Pais, string Nombre_Pais)
        {
            return "INSERT INTO pais(`Id_Pais`, `Nombre_Pais`) VALUES ('" + Id_Pais.ToString() + "', '" + Nombre_Pais.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla pais.
        /// </summary>
        /// <param name="Id_Pais">ID de la tabla</param>
        /// <param name="Nombre_Pais">Nombre del pais</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Pais, string Nombre_Pais, string Filtro)
        {
            return "UPDATE pais SET `Id_Pais` = '" + Id_Pais.ToString() + "', `Nombre_Pais` = '" + Nombre_Pais.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Pais.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Pais</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Pais Obj)
        {
            if (Obj.Nombre_Pais == null)
            {
                throw new Exception("Nombre_Pais no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO pais(`Nombre_Pais`)VALUES( " + "'" + Obj.Nombre_Pais + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Pais.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Pais</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Pais Obj)
        {
            if (Obj.Nombre_Pais == null)
            {
                throw new Exception("Nombre_Pais no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE pais SET `Nombre_Pais` =  '" + Obj.Nombre_Pais + "' WHERE pais.Id_Pais = " + Obj.Id_Pais.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Pais.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM pais WHERE pais.Id_Pais = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Pais. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Pais</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Pais Obj)
        {
            if (Obj.Nombre_Pais == null)
            {
                throw new Exception("Nombre_Pais no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO pais(`Nombre_Pais`)VALUES( " + "'" + Obj.Nombre_Pais + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Pais. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Pais</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Pais Obj)
        {
            if (Obj.Nombre_Pais == null)
            {
                throw new Exception("Nombre_Pais no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE pais SET `Nombre_Pais` =  '" + Obj.Nombre_Pais + "' WHERE pais.Id_Pais = " + Obj.Id_Pais.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Pais. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM pais WHERE pais.Id_Pais = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Provincias del sistema
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:36 a.m.
    /// </summary>
    public partial class Provincia
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Provincia()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Provincia</param>
        public Provincia(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Provincia"))
            {
                if (DataRowConstructor["Id_Provincia"] != DBNull.Value)
                {
                    this.Id_Provincia = Convert.ToInt32(DataRowConstructor["Id_Provincia"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Pais"))
            {
                if (DataRowConstructor["Id_Pais"] != DBNull.Value)
                {
                    this.Id_Pais = Convert.ToInt32(DataRowConstructor["Id_Pais"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Nombre_Provincia"))
            {
                if (DataRowConstructor["Nombre_Provincia"] != DBNull.Value)
                {
                    this.Nombre_Provincia = DataRowConstructor["Nombre_Provincia"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Provincia</param>
        public Provincia(DataSet DataSetConstructor)
        {
            this.ListaProvincia = new List<Provincia>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Provincia TEMP = new Provincia(Fila);
                TEMP.Pais = new Pais(Fila);
                this.ListaProvincia.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Provincia> ListaProvincia { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Provincia { get; set; }
        /// <summary>
        /// Id del pais
        /// </summary>
        public int Id_Pais { get; set; }
        /// <summary>
        /// Nombre de la provincia
        /// </summary>
        public string Nombre_Provincia { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Pais, Paises del sistema
        /// </summary>
        public Pais Pais { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla provincia.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Provincia`, `Id_Pais`, `Nombre_Provincia` FROM provincia " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla provincia.
        /// </summary>
        /// <param name="Id_Provincia">ID de la tabla</param>
        /// <param name="Id_Pais">Id del pais</param>
        /// <param name="Nombre_Provincia">Nombre de la provincia</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Provincia, int Id_Pais, string Nombre_Provincia)
        {
            return "INSERT INTO provincia(`Id_Provincia`, `Id_Pais`, `Nombre_Provincia`) VALUES ('" + Id_Provincia.ToString() + "', '" + Id_Pais.ToString() + "', '" + Nombre_Provincia.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla provincia.
        /// </summary>
        /// <param name="Id_Provincia">ID de la tabla</param>
        /// <param name="Id_Pais">Id del pais</param>
        /// <param name="Nombre_Provincia">Nombre de la provincia</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Provincia, int Id_Pais, string Nombre_Provincia, string Filtro)
        {
            return "UPDATE provincia SET `Id_Provincia` = '" + Id_Provincia.ToString() + "', `Id_Pais` = '" + Id_Pais.ToString() + "', `Nombre_Provincia` = '" + Nombre_Provincia.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Provincia.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Provincia</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Provincia Obj)
        {
            if (Obj.Nombre_Provincia == null)
            {
                throw new Exception("Nombre_Provincia no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO provincia(`Id_Pais`, `Nombre_Provincia`)VALUES( " + "'" + Obj.Id_Pais.ToString() + "', " + "'" + Obj.Nombre_Provincia + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Provincia.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Provincia</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Provincia Obj)
        {
            if (Obj.Nombre_Provincia == null)
            {
                throw new Exception("Nombre_Provincia no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE provincia SET `Id_Pais` =  '" + Obj.Id_Pais.ToString() + "', `Nombre_Provincia` =  '" + Obj.Nombre_Provincia + "' WHERE provincia.Id_Provincia = " + Obj.Id_Provincia.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Provincia.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM provincia WHERE provincia.Id_Provincia = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Provincia. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Provincia</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Provincia Obj)
        {
            if (Obj.Nombre_Provincia == null)
            {
                throw new Exception("Nombre_Provincia no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO provincia(`Id_Pais`, `Nombre_Provincia`)VALUES( " + "'" + Obj.Id_Pais.ToString() + "', " + "'" + Obj.Nombre_Provincia + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Provincia. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Provincia</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Provincia Obj)
        {
            if (Obj.Nombre_Provincia == null)
            {
                throw new Exception("Nombre_Provincia no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE provincia SET `Id_Pais` =  '" + Obj.Id_Pais.ToString() + "', `Nombre_Provincia` =  '" + Obj.Nombre_Provincia + "' WHERE provincia.Id_Provincia = " + Obj.Id_Provincia.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Provincia. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM provincia WHERE provincia.Id_Provincia = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Lleva el control del los auto incrementos de los comprobante
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:36 a.m.
    /// </summary>
    public partial class Series
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Series()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Series</param>
        public Series(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Comprobante"))
            {
                if (DataRowConstructor["Comprobante"] != DBNull.Value)
                {
                    this.Comprobante = DataRowConstructor["Comprobante"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero"))
            {
                if (DataRowConstructor["Numero"] != DBNull.Value)
                {
                    this.Numero = Convert.ToInt32(DataRowConstructor["Numero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Bloqueado"))
            {
                if (DataRowConstructor["Bloqueado"] != DBNull.Value)
                {
                    this.Bloqueado = Convert.ToBoolean(DataRowConstructor["Bloqueado"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Series</param>
        public Series(DataSet DataSetConstructor)
        {
            this.ListaSeries = new List<Series>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Series TEMP = new Series(Fila);
                this.ListaSeries.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Series> ListaSeries { get; set; }
        /// <summary>
        /// Tipo de comprobantes
        /// </summary>
        public string Comprobante { get; set; }
        /// <summary>
        /// Numero de comprobante siguiente
        /// </summary>
        public int Numero { get; set; }
        /// <summary>
        /// Verdadero si esta bloqueado
        /// </summary>
        public bool Bloqueado { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla series.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Comprobante`, `Numero`, `Bloqueado` FROM series " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla series.
        /// </summary>
        /// <param name="Comprobante">Tipo de comprobantes</param>
        /// <param name="Numero">Numero de comprobante siguiente</param>
        /// <param name="Bloqueado">Verdadero si esta bloqueado</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(string Comprobante, int Numero, bool Bloqueado)
        {
            return "INSERT INTO series(`Comprobante`, `Numero`, `Bloqueado`) VALUES ('" + Comprobante.ToString() + "', '" + Numero.ToString() + "', '" + Bloqueado.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla series.
        /// </summary>
        /// <param name="Comprobante">Tipo de comprobantes</param>
        /// <param name="Numero">Numero de comprobante siguiente</param>
        /// <param name="Bloqueado">Verdadero si esta bloqueado</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(string Comprobante, int Numero, bool Bloqueado, string Filtro)
        {
            return "UPDATE series SET `Comprobante` = '" + Comprobante.ToString() + "', `Numero` = '" + Numero.ToString() + "', `Bloqueado` = '" + Bloqueado.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Series.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Series</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Series Obj)
        {
            if (Obj.Comprobante == null)
            {
                throw new Exception("Comprobante no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO series(`Numero`, `Bloqueado`)VALUES( " + "'" + Obj.Numero.ToString() + "', " + Common.BoolToString(Obj.Bloqueado) + "" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Series.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Series</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Series Obj)
        {
            if (Obj.Comprobante == null)
            {
                throw new Exception("Comprobante no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE series SET `Numero` =  '" + Obj.Numero.ToString() + "', `Bloqueado` = " + Common.BoolToString(Obj.Bloqueado) + " WHERE series.Comprobante = " + Obj.Comprobante.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Series.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM series WHERE series.Comprobante = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Series. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Series</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Series Obj)
        {
            if (Obj.Comprobante == null)
            {
                throw new Exception("Comprobante no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO series(`Numero`, `Bloqueado`)VALUES( " + "'" + Obj.Numero.ToString() + "', " + Common.BoolToString(Obj.Bloqueado) + "" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Series. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Series</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Series Obj)
        {
            if (Obj.Comprobante == null)
            {
                throw new Exception("Comprobante no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE series SET `Numero` =  '" + Obj.Numero.ToString() + "', `Bloqueado` = " + Common.BoolToString(Obj.Bloqueado) + " WHERE series.Comprobante = " + Obj.Comprobante.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Series. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM series WHERE series.Comprobante = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Guarda los cliente y los proveedores
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 04:50:21 p.m.
    /// </summary>
    public partial class Tercero
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Tercero()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Tercero</param>
        public Tercero(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero"))
            {
                if (DataRowConstructor["Id_Tercero"] != DBNull.Value)
                {
                    this.Id_Tercero = Convert.ToInt32(DataRowConstructor["Id_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero_Tipo"))
            {
                if (DataRowConstructor["Id_Tercero_Tipo"] != DBNull.Value)
                {
                    this.Id_Tercero_Tipo = Convert.ToInt32(DataRowConstructor["Id_Tercero_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero_IVA"))
            {
                if (DataRowConstructor["Id_Tercero_IVA"] != DBNull.Value)
                {
                    this.Id_Tercero_IVA = Convert.ToInt32(DataRowConstructor["Id_Tercero_IVA"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Localidad"))
            {
                if (DataRowConstructor["Id_Localidad"] != DBNull.Value)
                {
                    this.Id_Localidad = Convert.ToInt32(DataRowConstructor["Id_Localidad"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Razon_Social_Tercero"))
            {
                if (DataRowConstructor["Razon_Social_Tercero"] != DBNull.Value)
                {
                    this.Razon_Social_Tercero = DataRowConstructor["Razon_Social_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Direccion_Tercero"))
            {
                if (DataRowConstructor["Direccion_Tercero"] != DBNull.Value)
                {
                    this.Direccion_Tercero = DataRowConstructor["Direccion_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Nacimiento_Tercero"))
            {
                if (DataRowConstructor["Fecha_Nacimiento_Tercero"] != DBNull.Value)
                {
                    this.Fecha_Nacimiento_Tercero = Convert.ToDateTime(DataRowConstructor["Fecha_Nacimiento_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("CUIT_Tercero"))
            {
                if (DataRowConstructor["CUIT_Tercero"] != DBNull.Value)
                {
                    this.CUIT_Tercero = DataRowConstructor["CUIT_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Telefonos_Tercero"))
            {
                if (DataRowConstructor["Telefonos_Tercero"] != DBNull.Value)
                {
                    this.Telefonos_Tercero = DataRowConstructor["Telefonos_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("DNI_Tercero"))
            {
                if (DataRowConstructor["DNI_Tercero"] != DBNull.Value)
                {
                    this.DNI_Tercero = Convert.ToInt32(DataRowConstructor["DNI_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fax_Tercero"))
            {
                if (DataRowConstructor["Fax_Tercero"] != DBNull.Value)
                {
                    this.Fax_Tercero = DataRowConstructor["Fax_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Email_Tercero"))
            {
                if (DataRowConstructor["Email_Tercero"] != DBNull.Value)
                {
                    this.Email_Tercero = DataRowConstructor["Email_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Alta_Tercero"))
            {
                if (DataRowConstructor["Fecha_Alta_Tercero"] != DBNull.Value)
                {
                    this.Fecha_Alta_Tercero = Convert.ToDateTime(DataRowConstructor["Fecha_Alta_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Baja_Tercero"))
            {
                if (DataRowConstructor["Fecha_Baja_Tercero"] != DBNull.Value)
                {
                    this.Fecha_Baja_Tercero = Convert.ToDateTime(DataRowConstructor["Fecha_Baja_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Anulado_Tercero"))
            {
                if (DataRowConstructor["Anulado_Tercero"] != DBNull.Value)
                {
                    this.Anulado_Tercero = Convert.ToBoolean(DataRowConstructor["Anulado_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Tercero"))
            {
                if (DataRowConstructor["Observaciones_Tercero"] != DBNull.Value)
                {
                    this.Observaciones_Tercero = DataRowConstructor["Observaciones_Tercero"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Tercero</param>
        public Tercero(DataSet DataSetConstructor)
        {
            this.ListaTercero = new List<Tercero>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Tercero TEMP = new Tercero(Fila);
                TEMP.Tercero_tipo = new Tercero_tipo(Fila);
                TEMP.Tercero_iva = new Tercero_iva(Fila);
                TEMP.Localidad = new Localidad(Fila);
                this.ListaTercero.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Tercero> ListaTercero { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Tercero { get; set; }
        /// <summary>
        /// Para saber si proveedor o cliente
        /// </summary>
        public int Id_Tercero_Tipo { get; set; }
        /// <summary>
        /// La condicion de iva del tercero
        /// </summary>
        public int Id_Tercero_IVA { get; set; }
        /// <summary>
        /// ID de la localidad de la aplicacion
        /// </summary>
        public int Id_Localidad { get; set; }
        /// <summary>
        /// Razon social, nombre y apellido del tercero
        /// </summary>
        public string Razon_Social_Tercero { get; set; }
        /// <summary>
        /// Direccion del tercero
        /// </summary>
        public string Direccion_Tercero { get; set; }
        /// <summary>
        /// Fecha de nacimiento
        /// </summary>
        public DateTime Fecha_Nacimiento_Tercero { get; set; }
        /// <summary>
        /// CUIT del tercero (por lo general a proveedores
        /// </summary>
        public string CUIT_Tercero { get; set; }
        /// <summary>
        /// Telefonos del tercero
        /// </summary>
        public string Telefonos_Tercero { get; set; }
        /// <summary>
        /// DNI del tercero
        /// </summary>
        public int DNI_Tercero { get; set; }
        /// <summary>
        /// Fax del tercer
        /// </summary>
        public string Fax_Tercero { get; set; }
        /// <summary>
        /// "Email del tercero
        /// </summary>
        public string Email_Tercero { get; set; }
        /// <summary>
        /// Fecha de alta del tercero
        /// </summary>
        public DateTime Fecha_Alta_Tercero { get; set; }
        /// <summary>
        /// Fecha de baja del tercero
        /// </summary>
        public DateTime Fecha_Baja_Tercero { get; set; }
        /// <summary>
        /// Es verdadero si esta anulado este tercero
        /// </summary>
        public bool Anulado_Tercero { get; set; }
        /// <summary>
        /// Observaciones del tercero
        /// </summary>
        public string Observaciones_Tercero { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero_tipo, Para saber si es proveedor o cliente
        /// </summary>
        public Tercero_tipo Tercero_tipo { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero_iva, Tipo de condicion de IVA
        /// </summary>
        public Tercero_iva Tercero_iva { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Localidad, Ciudades del sistema
        /// </summary>
        public Localidad Localidad { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla tercero.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Tercero`, `Id_Tercero_Tipo`, `Id_Tercero_IVA`, `Id_Localidad`, `Razon_Social_Tercero`, `Direccion_Tercero`, `Fecha_Nacimiento_Tercero`, `CUIT_Tercero`, `Telefonos_Tercero`, `DNI_Tercero`, `Fax_Tercero`, `Email_Tercero`, `Fecha_Alta_Tercero`, `Fecha_Baja_Tercero`, `Anulado_Tercero`, `Observaciones_Tercero` FROM tercero " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla tercero.
        /// </summary>
        /// <param name="Id_Tercero">ID de la tabla</param>
        /// <param name="Id_Tercero_Tipo">Para saber si proveedor o cliente</param>
        /// <param name="Id_Tercero_IVA">La condicion de iva del tercero</param>
        /// <param name="Id_Localidad">ID de la localidad de la aplicacion</param>
        /// <param name="Razon_Social_Tercero">Razon social, nombre y apellido del tercero</param>
        /// <param name="Direccion_Tercero">Direccion del tercero</param>
        /// <param name="Fecha_Nacimiento_Tercero">Fecha de nacimiento</param>
        /// <param name="CUIT_Tercero">CUIT del tercero (por lo general a proveedores</param>
        /// <param name="Telefonos_Tercero">Telefonos del tercero</param>
        /// <param name="DNI_Tercero">DNI del tercero</param>
        /// <param name="Fax_Tercero">Fax del tercer</param>
        /// <param name="Email_Tercero">"Email del tercero</param>
        /// <param name="Fecha_Alta_Tercero">Fecha de alta del tercero</param>
        /// <param name="Fecha_Baja_Tercero">Fecha de baja del tercero</param>
        /// <param name="Anulado_Tercero">Es verdadero si esta anulado este tercero</param>
        /// <param name="Observaciones_Tercero">Observaciones del tercero</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Tercero, int Id_Tercero_Tipo, int Id_Tercero_IVA, int Id_Localidad, string Razon_Social_Tercero, string Direccion_Tercero, DateTime Fecha_Nacimiento_Tercero, string CUIT_Tercero, string Telefonos_Tercero, int DNI_Tercero, string Fax_Tercero, string Email_Tercero, DateTime Fecha_Alta_Tercero, DateTime Fecha_Baja_Tercero, bool Anulado_Tercero, string Observaciones_Tercero)
        {
            return "INSERT INTO tercero(`Id_Tercero`, `Id_Tercero_Tipo`, `Id_Tercero_IVA`, `Id_Localidad`, `Razon_Social_Tercero`, `Direccion_Tercero`, `Fecha_Nacimiento_Tercero`, `CUIT_Tercero`, `Telefonos_Tercero`, `DNI_Tercero`, `Fax_Tercero`, `Email_Tercero`, `Fecha_Alta_Tercero`, `Fecha_Baja_Tercero`, `Anulado_Tercero`, `Observaciones_Tercero`) VALUES ('" + Id_Tercero.ToString() + "', '" + Id_Tercero_Tipo.ToString() + "', '" + Id_Tercero_IVA.ToString() + "', '" + Id_Localidad.ToString() + "', '" + Razon_Social_Tercero.ToString() + "', '" + Direccion_Tercero.ToString() + "', '" + Fecha_Nacimiento_Tercero.ToString() + "', '" + CUIT_Tercero.ToString() + "', '" + Telefonos_Tercero.ToString() + "', '" + DNI_Tercero.ToString() + "', '" + Fax_Tercero.ToString() + "', '" + Email_Tercero.ToString() + "', '" + Fecha_Alta_Tercero.ToString() + "', '" + Fecha_Baja_Tercero.ToString() + "', '" + Anulado_Tercero.ToString() + "', '" + Observaciones_Tercero.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla tercero.
        /// </summary>
        /// <param name="Id_Tercero">ID de la tabla</param>
        /// <param name="Id_Tercero_Tipo">Para saber si proveedor o cliente</param>
        /// <param name="Id_Tercero_IVA">La condicion de iva del tercero</param>
        /// <param name="Id_Localidad">ID de la localidad de la aplicacion</param>
        /// <param name="Razon_Social_Tercero">Razon social, nombre y apellido del tercero</param>
        /// <param name="Direccion_Tercero">Direccion del tercero</param>
        /// <param name="Fecha_Nacimiento_Tercero">Fecha de nacimiento</param>
        /// <param name="CUIT_Tercero">CUIT del tercero (por lo general a proveedores</param>
        /// <param name="Telefonos_Tercero">Telefonos del tercero</param>
        /// <param name="DNI_Tercero">DNI del tercero</param>
        /// <param name="Fax_Tercero">Fax del tercer</param>
        /// <param name="Email_Tercero">"Email del tercero</param>
        /// <param name="Fecha_Alta_Tercero">Fecha de alta del tercero</param>
        /// <param name="Fecha_Baja_Tercero">Fecha de baja del tercero</param>
        /// <param name="Anulado_Tercero">Es verdadero si esta anulado este tercero</param>
        /// <param name="Observaciones_Tercero">Observaciones del tercero</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Tercero, int Id_Tercero_Tipo, int Id_Tercero_IVA, int Id_Localidad, string Razon_Social_Tercero, string Direccion_Tercero, DateTime Fecha_Nacimiento_Tercero, string CUIT_Tercero, string Telefonos_Tercero, int DNI_Tercero, string Fax_Tercero, string Email_Tercero, DateTime Fecha_Alta_Tercero, DateTime Fecha_Baja_Tercero, bool Anulado_Tercero, string Observaciones_Tercero, string Filtro)
        {
            return "UPDATE tercero SET `Id_Tercero` = '" + Id_Tercero.ToString() + "', `Id_Tercero_Tipo` = '" + Id_Tercero_Tipo.ToString() + "', `Id_Tercero_IVA` = '" + Id_Tercero_IVA.ToString() + "', `Id_Localidad` = '" + Id_Localidad.ToString() + "', `Razon_Social_Tercero` = '" + Razon_Social_Tercero.ToString() + "', `Direccion_Tercero` = '" + Direccion_Tercero.ToString() + "', `Fecha_Nacimiento_Tercero` = '" + Fecha_Nacimiento_Tercero.ToString() + "', `CUIT_Tercero` = '" + CUIT_Tercero.ToString() + "', `Telefonos_Tercero` = '" + Telefonos_Tercero.ToString() + "', `DNI_Tercero` = '" + DNI_Tercero.ToString() + "', `Fax_Tercero` = '" + Fax_Tercero.ToString() + "', `Email_Tercero` = '" + Email_Tercero.ToString() + "', `Fecha_Alta_Tercero` = '" + Fecha_Alta_Tercero.ToString() + "', `Fecha_Baja_Tercero` = '" + Fecha_Baja_Tercero.ToString() + "', `Anulado_Tercero` = '" + Anulado_Tercero.ToString() + "', `Observaciones_Tercero` = '" + Observaciones_Tercero.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Tercero Obj)
        {
            if (Obj.Razon_Social_Tercero == null)
            {
                throw new Exception("Razon_Social_Tercero no puede ser null");
            }
            if (Obj.Direccion_Tercero == null)
            {
                throw new Exception("Direccion_Tercero no puede ser null");
            }
            if (Obj.Fecha_Nacimiento_Tercero == null)
            {
                throw new Exception("Fecha_Nacimiento_Tercero no puede ser null");
            }
            if (Obj.CUIT_Tercero == null)
            {
                throw new Exception("CUIT_Tercero no puede ser null");
            }
            if (Obj.Telefonos_Tercero == null)
            {
                throw new Exception("Telefonos_Tercero no puede ser null");
            }
            if (Obj.Fax_Tercero == null)
            {
                throw new Exception("Fax_Tercero no puede ser null");
            }
            if (Obj.Email_Tercero == null)
            {
                throw new Exception("Email_Tercero no puede ser null");
            }
            if (Obj.Fecha_Alta_Tercero == null)
            {
                throw new Exception("Fecha_Alta_Tercero no puede ser null");
            }
            if (Obj.Fecha_Baja_Tercero == null)
            {
                throw new Exception("Fecha_Baja_Tercero no puede ser null");
            }
            if (Obj.Observaciones_Tercero == null)
            {
                throw new Exception("Observaciones_Tercero no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO tercero(`Id_Tercero_Tipo`, `Id_Tercero_IVA`, `Id_Localidad`, `Razon_Social_Tercero`, `Direccion_Tercero`, `Fecha_Nacimiento_Tercero`, `CUIT_Tercero`, `Telefonos_Tercero`, `DNI_Tercero`, `Fax_Tercero`, `Email_Tercero`, `Fecha_Alta_Tercero`, `Fecha_Baja_Tercero`, `Anulado_Tercero`, `Observaciones_Tercero`)VALUES( " + "'" + Obj.Id_Tercero_Tipo.ToString() + "', " + "'" + Obj.Id_Tercero_IVA.ToString() + "', " + "'" + Obj.Id_Localidad.ToString() + "', " + "'" + Obj.Razon_Social_Tercero + "', " + "'" + Obj.Direccion_Tercero + "', " + "'" + Obj.Fecha_Nacimiento_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.CUIT_Tercero + "', " + "'" + Obj.Telefonos_Tercero + "', " + "'" + Obj.DNI_Tercero.ToString() + "', " + "'" + Obj.Fax_Tercero + "', " + "'" + Obj.Email_Tercero + "', " + "'" + Obj.Fecha_Alta_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Baja_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + Common.BoolToString(Obj.Anulado_Tercero) + ", " + "'" + Obj.Observaciones_Tercero + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Tercero.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Tercero Obj)
        {
            if (Obj.Razon_Social_Tercero == null)
            {
                throw new Exception("Razon_Social_Tercero no puede ser null");
            }
            if (Obj.Direccion_Tercero == null)
            {
                throw new Exception("Direccion_Tercero no puede ser null");
            }
            if (Obj.Fecha_Nacimiento_Tercero == null)
            {
                throw new Exception("Fecha_Nacimiento_Tercero no puede ser null");
            }
            if (Obj.CUIT_Tercero == null)
            {
                throw new Exception("CUIT_Tercero no puede ser null");
            }
            if (Obj.Telefonos_Tercero == null)
            {
                throw new Exception("Telefonos_Tercero no puede ser null");
            }
            if (Obj.Fax_Tercero == null)
            {
                throw new Exception("Fax_Tercero no puede ser null");
            }
            if (Obj.Email_Tercero == null)
            {
                throw new Exception("Email_Tercero no puede ser null");
            }
            if (Obj.Fecha_Alta_Tercero == null)
            {
                throw new Exception("Fecha_Alta_Tercero no puede ser null");
            }
            if (Obj.Fecha_Baja_Tercero == null)
            {
                throw new Exception("Fecha_Baja_Tercero no puede ser null");
            }
            if (Obj.Observaciones_Tercero == null)
            {
                throw new Exception("Observaciones_Tercero no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE tercero SET `Id_Tercero_Tipo` =  '" + Obj.Id_Tercero_Tipo.ToString() + "', `Id_Tercero_IVA` =  '" + Obj.Id_Tercero_IVA.ToString() + "', `Id_Localidad` =  '" + Obj.Id_Localidad.ToString() + "', `Razon_Social_Tercero` =  '" + Obj.Razon_Social_Tercero + "', `Direccion_Tercero` =  '" + Obj.Direccion_Tercero + "', `Fecha_Nacimiento_Tercero` =  '" + Obj.Fecha_Nacimiento_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `CUIT_Tercero` =  '" + Obj.CUIT_Tercero + "', `Telefonos_Tercero` =  '" + Obj.Telefonos_Tercero + "', `DNI_Tercero` =  '" + Obj.DNI_Tercero.ToString() + "', `Fax_Tercero` =  '" + Obj.Fax_Tercero + "', `Email_Tercero` =  '" + Obj.Email_Tercero + "', `Fecha_Alta_Tercero` =  '" + Obj.Fecha_Alta_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Baja_Tercero` =  '" + Obj.Fecha_Baja_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `Anulado_Tercero` = " + Common.BoolToString(Obj.Anulado_Tercero) + ", `Observaciones_Tercero` =  '" + Obj.Observaciones_Tercero + "' WHERE tercero.Id_Tercero = " + Obj.Id_Tercero.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Tercero.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM tercero WHERE tercero.Id_Tercero = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Tercero. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Tercero Obj)
        {
            if (Obj.Razon_Social_Tercero == null)
            {
                throw new Exception("Razon_Social_Tercero no puede ser null");
            }
            if (Obj.Direccion_Tercero == null)
            {
                throw new Exception("Direccion_Tercero no puede ser null");
            }
            if (Obj.Fecha_Nacimiento_Tercero == null)
            {
                throw new Exception("Fecha_Nacimiento_Tercero no puede ser null");
            }
            if (Obj.CUIT_Tercero == null)
            {
                throw new Exception("CUIT_Tercero no puede ser null");
            }
            if (Obj.Telefonos_Tercero == null)
            {
                throw new Exception("Telefonos_Tercero no puede ser null");
            }
            if (Obj.Fax_Tercero == null)
            {
                throw new Exception("Fax_Tercero no puede ser null");
            }
            if (Obj.Email_Tercero == null)
            {
                throw new Exception("Email_Tercero no puede ser null");
            }
            if (Obj.Fecha_Alta_Tercero == null)
            {
                throw new Exception("Fecha_Alta_Tercero no puede ser null");
            }
            if (Obj.Fecha_Baja_Tercero == null)
            {
                throw new Exception("Fecha_Baja_Tercero no puede ser null");
            }
            if (Obj.Observaciones_Tercero == null)
            {
                throw new Exception("Observaciones_Tercero no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO tercero(`Id_Tercero_Tipo`, `Id_Tercero_IVA`, `Id_Localidad`, `Razon_Social_Tercero`, `Direccion_Tercero`, `Fecha_Nacimiento_Tercero`, `CUIT_Tercero`, `Telefonos_Tercero`, `DNI_Tercero`, `Fax_Tercero`, `Email_Tercero`, `Fecha_Alta_Tercero`, `Fecha_Baja_Tercero`, `Anulado_Tercero`, `Observaciones_Tercero`)VALUES( " + "'" + Obj.Id_Tercero_Tipo.ToString() + "', " + "'" + Obj.Id_Tercero_IVA.ToString() + "', " + "'" + Obj.Id_Localidad.ToString() + "', " + "'" + Obj.Razon_Social_Tercero + "', " + "'" + Obj.Direccion_Tercero + "', " + "'" + Obj.Fecha_Nacimiento_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.CUIT_Tercero + "', " + "'" + Obj.Telefonos_Tercero + "', " + "'" + Obj.DNI_Tercero.ToString() + "', " + "'" + Obj.Fax_Tercero + "', " + "'" + Obj.Email_Tercero + "', " + "'" + Obj.Fecha_Alta_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Baja_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + Common.BoolToString(Obj.Anulado_Tercero) + ", " + "'" + Obj.Observaciones_Tercero + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Tercero Obj)
        {
            if (Obj.Razon_Social_Tercero == null)
            {
                throw new Exception("Razon_Social_Tercero no puede ser null");
            }
            if (Obj.Direccion_Tercero == null)
            {
                throw new Exception("Direccion_Tercero no puede ser null");
            }
            if (Obj.Fecha_Nacimiento_Tercero == null)
            {
                throw new Exception("Fecha_Nacimiento_Tercero no puede ser null");
            }
            if (Obj.CUIT_Tercero == null)
            {
                throw new Exception("CUIT_Tercero no puede ser null");
            }
            if (Obj.Telefonos_Tercero == null)
            {
                throw new Exception("Telefonos_Tercero no puede ser null");
            }
            if (Obj.Fax_Tercero == null)
            {
                throw new Exception("Fax_Tercero no puede ser null");
            }
            if (Obj.Email_Tercero == null)
            {
                throw new Exception("Email_Tercero no puede ser null");
            }
            if (Obj.Fecha_Alta_Tercero == null)
            {
                throw new Exception("Fecha_Alta_Tercero no puede ser null");
            }
            if (Obj.Fecha_Baja_Tercero == null)
            {
                throw new Exception("Fecha_Baja_Tercero no puede ser null");
            }
            if (Obj.Observaciones_Tercero == null)
            {
                throw new Exception("Observaciones_Tercero no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE tercero SET `Id_Tercero_Tipo` =  '" + Obj.Id_Tercero_Tipo.ToString() + "', `Id_Tercero_IVA` =  '" + Obj.Id_Tercero_IVA.ToString() + "', `Id_Localidad` =  '" + Obj.Id_Localidad.ToString() + "', `Razon_Social_Tercero` =  '" + Obj.Razon_Social_Tercero + "', `Direccion_Tercero` =  '" + Obj.Direccion_Tercero + "', `Fecha_Nacimiento_Tercero` =  '" + Obj.Fecha_Nacimiento_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `CUIT_Tercero` =  '" + Obj.CUIT_Tercero + "', `Telefonos_Tercero` =  '" + Obj.Telefonos_Tercero + "', `DNI_Tercero` =  '" + Obj.DNI_Tercero.ToString() + "', `Fax_Tercero` =  '" + Obj.Fax_Tercero + "', `Email_Tercero` =  '" + Obj.Email_Tercero + "', `Fecha_Alta_Tercero` =  '" + Obj.Fecha_Alta_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Baja_Tercero` =  '" + Obj.Fecha_Baja_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `Anulado_Tercero` = " + Common.BoolToString(Obj.Anulado_Tercero) + ", `Observaciones_Tercero` =  '" + Obj.Observaciones_Tercero + "' WHERE tercero.Id_Tercero = " + Obj.Id_Tercero.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM tercero WHERE tercero.Id_Tercero = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Tipo de condicion de IVA
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:36 a.m.
    /// </summary>
    public partial class Tercero_iva
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Tercero_iva()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Tercero_iva</param>
        public Tercero_iva(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero_IVA"))
            {
                if (DataRowConstructor["Id_Tercero_IVA"] != DBNull.Value)
                {
                    this.Id_Tercero_IVA = Convert.ToInt32(DataRowConstructor["Id_Tercero_IVA"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Tercero_IVA"))
            {
                if (DataRowConstructor["Descripcion_Tercero_IVA"] != DBNull.Value)
                {
                    this.Descripcion_Tercero_IVA = DataRowConstructor["Descripcion_Tercero_IVA"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Abreviacion_Tercero_IVA"))
            {
                if (DataRowConstructor["Abreviacion_Tercero_IVA"] != DBNull.Value)
                {
                    this.Abreviacion_Tercero_IVA = DataRowConstructor["Abreviacion_Tercero_IVA"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Clase_Comprobante_Compra_Tercero_IVA"))
            {
                if (DataRowConstructor["Clase_Comprobante_Compra_Tercero_IVA"] != DBNull.Value)
                {
                    this.Clase_Comprobante_Compra_Tercero_IVA = DataRowConstructor["Clase_Comprobante_Compra_Tercero_IVA"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Clase_Comprobante_Venta_Tercero_IVA"))
            {
                if (DataRowConstructor["Clase_Comprobante_Venta_Tercero_IVA"] != DBNull.Value)
                {
                    this.Clase_Comprobante_Venta_Tercero_IVA = DataRowConstructor["Clase_Comprobante_Venta_Tercero_IVA"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Tercero_iva</param>
        public Tercero_iva(DataSet DataSetConstructor)
        {
            this.ListaTercero_iva = new List<Tercero_iva>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Tercero_iva TEMP = new Tercero_iva(Fila);
                this.ListaTercero_iva.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Tercero_iva> ListaTercero_iva { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Tercero_IVA { get; set; }
        /// <summary>
        /// Descripcion del tipo de iva/ condicion del tercero
        /// </summary>
        public string Descripcion_Tercero_IVA { get; set; }
        /// <summary>
        /// Abreviatura del la descripcion
        /// </summary>
        public string Abreviacion_Tercero_IVA { get; set; }
        /// <summary>
        /// Clase que se usa para este tipo de iva en la compra
        /// </summary>
        public string Clase_Comprobante_Compra_Tercero_IVA { get; set; }
        /// <summary>
        /// Clase que se usa para este tipo de iva en la venta
        /// </summary>
        public string Clase_Comprobante_Venta_Tercero_IVA { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla tercero_iva.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Tercero_IVA`, `Descripcion_Tercero_IVA`, `Abreviacion_Tercero_IVA`, `Clase_Comprobante_Compra_Tercero_IVA`, `Clase_Comprobante_Venta_Tercero_IVA` FROM tercero_iva " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla tercero_iva.
        /// </summary>
        /// <param name="Id_Tercero_IVA">ID de la tabla</param>
        /// <param name="Descripcion_Tercero_IVA">Descripcion del tipo de iva/ condicion del tercero</param>
        /// <param name="Abreviacion_Tercero_IVA">Abreviatura del la descripcion</param>
        /// <param name="Clase_Comprobante_Compra_Tercero_IVA">Clase que se usa para este tipo de iva en la compra</param>
        /// <param name="Clase_Comprobante_Venta_Tercero_IVA">Clase que se usa para este tipo de iva en la venta</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Tercero_IVA, string Descripcion_Tercero_IVA, string Abreviacion_Tercero_IVA, string Clase_Comprobante_Compra_Tercero_IVA, string Clase_Comprobante_Venta_Tercero_IVA)
        {
            return "INSERT INTO tercero_iva(`Id_Tercero_IVA`, `Descripcion_Tercero_IVA`, `Abreviacion_Tercero_IVA`, `Clase_Comprobante_Compra_Tercero_IVA`, `Clase_Comprobante_Venta_Tercero_IVA`) VALUES ('" + Id_Tercero_IVA.ToString() + "', '" + Descripcion_Tercero_IVA.ToString() + "', '" + Abreviacion_Tercero_IVA.ToString() + "', '" + Clase_Comprobante_Compra_Tercero_IVA.ToString() + "', '" + Clase_Comprobante_Venta_Tercero_IVA.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla tercero_iva.
        /// </summary>
        /// <param name="Id_Tercero_IVA">ID de la tabla</param>
        /// <param name="Descripcion_Tercero_IVA">Descripcion del tipo de iva/ condicion del tercero</param>
        /// <param name="Abreviacion_Tercero_IVA">Abreviatura del la descripcion</param>
        /// <param name="Clase_Comprobante_Compra_Tercero_IVA">Clase que se usa para este tipo de iva en la compra</param>
        /// <param name="Clase_Comprobante_Venta_Tercero_IVA">Clase que se usa para este tipo de iva en la venta</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Tercero_IVA, string Descripcion_Tercero_IVA, string Abreviacion_Tercero_IVA, string Clase_Comprobante_Compra_Tercero_IVA, string Clase_Comprobante_Venta_Tercero_IVA, string Filtro)
        {
            return "UPDATE tercero_iva SET `Id_Tercero_IVA` = '" + Id_Tercero_IVA.ToString() + "', `Descripcion_Tercero_IVA` = '" + Descripcion_Tercero_IVA.ToString() + "', `Abreviacion_Tercero_IVA` = '" + Abreviacion_Tercero_IVA.ToString() + "', `Clase_Comprobante_Compra_Tercero_IVA` = '" + Clase_Comprobante_Compra_Tercero_IVA.ToString() + "', `Clase_Comprobante_Venta_Tercero_IVA` = '" + Clase_Comprobante_Venta_Tercero_IVA.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero_iva.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_iva</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Tercero_iva Obj)
        {
            if (Obj.Descripcion_Tercero_IVA == null)
            {
                throw new Exception("Descripcion_Tercero_IVA no puede ser null");
            }
            if (Obj.Abreviacion_Tercero_IVA == null)
            {
                throw new Exception("Abreviacion_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Compra_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Compra_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Venta_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Venta_Tercero_IVA no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO tercero_iva(`Descripcion_Tercero_IVA`, `Abreviacion_Tercero_IVA`, `Clase_Comprobante_Compra_Tercero_IVA`, `Clase_Comprobante_Venta_Tercero_IVA`)VALUES( " + "'" + Obj.Descripcion_Tercero_IVA + "', " + "'" + Obj.Abreviacion_Tercero_IVA + "', " + "'" + Obj.Clase_Comprobante_Compra_Tercero_IVA + "', " + "'" + Obj.Clase_Comprobante_Venta_Tercero_IVA + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Tercero_iva.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_iva</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Tercero_iva Obj)
        {
            if (Obj.Descripcion_Tercero_IVA == null)
            {
                throw new Exception("Descripcion_Tercero_IVA no puede ser null");
            }
            if (Obj.Abreviacion_Tercero_IVA == null)
            {
                throw new Exception("Abreviacion_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Compra_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Compra_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Venta_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Venta_Tercero_IVA no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE tercero_iva SET `Descripcion_Tercero_IVA` =  '" + Obj.Descripcion_Tercero_IVA + "', `Abreviacion_Tercero_IVA` =  '" + Obj.Abreviacion_Tercero_IVA + "', `Clase_Comprobante_Compra_Tercero_IVA` =  '" + Obj.Clase_Comprobante_Compra_Tercero_IVA + "', `Clase_Comprobante_Venta_Tercero_IVA` =  '" + Obj.Clase_Comprobante_Venta_Tercero_IVA + "' WHERE tercero_iva.Id_Tercero_IVA = " + Obj.Id_Tercero_IVA.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Tercero_iva.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM tercero_iva WHERE tercero_iva.Id_Tercero_IVA = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Tercero_iva. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_iva</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Tercero_iva Obj)
        {
            if (Obj.Descripcion_Tercero_IVA == null)
            {
                throw new Exception("Descripcion_Tercero_IVA no puede ser null");
            }
            if (Obj.Abreviacion_Tercero_IVA == null)
            {
                throw new Exception("Abreviacion_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Compra_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Compra_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Venta_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Venta_Tercero_IVA no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO tercero_iva(`Descripcion_Tercero_IVA`, `Abreviacion_Tercero_IVA`, `Clase_Comprobante_Compra_Tercero_IVA`, `Clase_Comprobante_Venta_Tercero_IVA`)VALUES( " + "'" + Obj.Descripcion_Tercero_IVA + "', " + "'" + Obj.Abreviacion_Tercero_IVA + "', " + "'" + Obj.Clase_Comprobante_Compra_Tercero_IVA + "', " + "'" + Obj.Clase_Comprobante_Venta_Tercero_IVA + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero_iva. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_iva</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Tercero_iva Obj)
        {
            if (Obj.Descripcion_Tercero_IVA == null)
            {
                throw new Exception("Descripcion_Tercero_IVA no puede ser null");
            }
            if (Obj.Abreviacion_Tercero_IVA == null)
            {
                throw new Exception("Abreviacion_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Compra_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Compra_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Venta_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Venta_Tercero_IVA no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE tercero_iva SET `Descripcion_Tercero_IVA` =  '" + Obj.Descripcion_Tercero_IVA + "', `Abreviacion_Tercero_IVA` =  '" + Obj.Abreviacion_Tercero_IVA + "', `Clase_Comprobante_Compra_Tercero_IVA` =  '" + Obj.Clase_Comprobante_Compra_Tercero_IVA + "', `Clase_Comprobante_Venta_Tercero_IVA` =  '" + Obj.Clase_Comprobante_Venta_Tercero_IVA + "' WHERE tercero_iva.Id_Tercero_IVA = " + Obj.Id_Tercero_IVA.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero_iva. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM tercero_iva WHERE tercero_iva.Id_Tercero_IVA = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Para saber si es proveedor o cliente
    /// La última modificación fué el sábado, 08 de octubre de 2011 a las 10:12:36 a.m.
    /// </summary>
    public partial class Tercero_tipo
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Tercero_tipo()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Tercero_tipo</param>
        public Tercero_tipo(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero_Tipo"))
            {
                if (DataRowConstructor["Id_Tercero_Tipo"] != DBNull.Value)
                {
                    this.Id_Tercero_Tipo = Convert.ToInt32(DataRowConstructor["Id_Tercero_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Tercero_Tipo"))
            {
                if (DataRowConstructor["Descripcion_Tercero_Tipo"] != DBNull.Value)
                {
                    this.Descripcion_Tercero_Tipo = DataRowConstructor["Descripcion_Tercero_Tipo"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Tercero_tipo</param>
        public Tercero_tipo(DataSet DataSetConstructor)
        {
            this.ListaTercero_tipo = new List<Tercero_tipo>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Tercero_tipo TEMP = new Tercero_tipo(Fila);
                this.ListaTercero_tipo.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Tercero_tipo> ListaTercero_tipo { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Tercero_Tipo { get; set; }
        /// <summary>
        /// Descripcion del tipo de tipo de tercero
        /// </summary>
        public string Descripcion_Tercero_Tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla tercero_tipo.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Tercero_Tipo`, `Descripcion_Tercero_Tipo` FROM tercero_tipo " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla tercero_tipo.
        /// </summary>
        /// <param name="Id_Tercero_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Tercero_Tipo">Descripcion del tipo de tipo de tercero</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Tercero_Tipo, string Descripcion_Tercero_Tipo)
        {
            return "INSERT INTO tercero_tipo(`Id_Tercero_Tipo`, `Descripcion_Tercero_Tipo`) VALUES ('" + Id_Tercero_Tipo.ToString() + "', '" + Descripcion_Tercero_Tipo.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla tercero_tipo.
        /// </summary>
        /// <param name="Id_Tercero_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Tercero_Tipo">Descripcion del tipo de tipo de tercero</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Tercero_Tipo, string Descripcion_Tercero_Tipo, string Filtro)
        {
            return "UPDATE tercero_tipo SET `Id_Tercero_Tipo` = '" + Id_Tercero_Tipo.ToString() + "', `Descripcion_Tercero_Tipo` = '" + Descripcion_Tercero_Tipo.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Tercero_tipo Obj)
        {
            if (Obj.Descripcion_Tercero_Tipo == null)
            {
                throw new Exception("Descripcion_Tercero_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO tercero_tipo(`Descripcion_Tercero_Tipo`)VALUES( " + "'" + Obj.Descripcion_Tercero_Tipo + "'" + ");"))
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
        /// <summary>
        /// Actualiza un fila a la tabla Tercero_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Tercero_tipo Obj)
        {
            if (Obj.Descripcion_Tercero_Tipo == null)
            {
                throw new Exception("Descripcion_Tercero_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE tercero_tipo SET `Descripcion_Tercero_Tipo` =  '" + Obj.Descripcion_Tercero_Tipo + "' WHERE tercero_tipo.Id_Tercero_Tipo = " + Obj.Id_Tercero_Tipo.ToString() + ";"))
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
        /// <summary>
        /// Borra una fila de la tabla Tercero_tipo.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM tercero_tipo WHERE tercero_tipo.Id_Tercero_Tipo = " + Id + ";"))
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
        /// <summary>
        /// Agrega un fila a la tabla Tercero_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Tercero_tipo Obj)
        {
            if (Obj.Descripcion_Tercero_Tipo == null)
            {
                throw new Exception("Descripcion_Tercero_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO tercero_tipo(`Descripcion_Tercero_Tipo`)VALUES( " + "'" + Obj.Descripcion_Tercero_Tipo + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Tercero_tipo Obj)
        {
            if (Obj.Descripcion_Tercero_Tipo == null)
            {
                throw new Exception("Descripcion_Tercero_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE tercero_tipo SET `Descripcion_Tercero_Tipo` =  '" + Obj.Descripcion_Tercero_Tipo + "' WHERE tercero_tipo.Id_Tercero_Tipo = " + Obj.Id_Tercero_Tipo.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM tercero_tipo WHERE tercero_tipo.Id_Tercero_Tipo = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
}
