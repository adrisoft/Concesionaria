-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: db
-- Generation Time: Jun 29, 2020 at 05:23 PM
-- Server version: 5.5.62
-- PHP Version: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sistema`
--

-- --------------------------------------------------------

--
-- Table structure for table `articulo`
--

CREATE TABLE `articulo` (
  `Id_Articulo` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Tercero` int(6) NOT NULL COMMENT 'Tercero que provee este articulo',
  `Id_Linea` int(6) NOT NULL COMMENT 'ID de la linea',
  `Id_Categoria` int(6) NOT NULL COMMENT 'ID de la categoria',
  `Codigo_Articulo` varchar(25) NOT NULL COMMENT 'Codigo del articulo',
  `Numero_Chasis_Articulo` varchar(25) NOT NULL COMMENT 'Numero del chasis, esto es solo para las motos',
  `Numero_Motor_Articulo` varchar(25) NOT NULL COMMENT 'Numero del motor, esto es solo para las motos',
  `Certificado_Fabricacion_Articulo` varchar(25) NOT NULL COMMENT 'Certificado de fabricacion del automotor',
  `Numero_Aduana_Articulo` varchar(255) NOT NULL COMMENT 'Algun numero de control de aduana',
  `Descripcion_Articulo` varchar(255) NOT NULL COMMENT 'Descripcion del articulo',
  `Anulado_Articulo` bit(1) NOT NULL COMMENT 'es verdadero si esta anulado',
  `Stock_Minimo_Articulo` int(6) NOT NULL COMMENT 'Cantidad minima del articulo',
  `Stock_Articulo` int(6) NOT NULL COMMENT 'Cantidad de articulos que hay en existencia',
  `Peso_Articulo` decimal(6,2) NOT NULL COMMENT 'Peso del articulo',
  `Dia_Compra_Articulo` datetime NOT NULL COMMENT 'Ultimo dia de compra de este articulo',
  `Dia_Venta_Articulo` datetime NOT NULL COMMENT 'Ultimo dia de la venta de este articul',
  `Precio_Costo_Articulo` decimal(10,4) NOT NULL COMMENT 'Precio de costo de este articulo',
  `Precio_Venta_Articulo` decimal(10,4) NOT NULL COMMENT 'Precio de venta de este articulo',
  `IVA_Articulo` decimal(10,4) NOT NULL COMMENT 'Porcentaje de IVA de este articulo',
  `Garantia_Articulo` int(6) NOT NULL COMMENT 'Numero de meses de garantia',
  `Dominio_Articulo` varchar(255) NOT NULL COMMENT 'Dominio del ciclomotor',
  `ExTitular` varchar(255) NOT NULL COMMENT 'Extitular del ciclomotor',
  `Cuadro` varchar(255) NOT NULL COMMENT 'Cuadro',
  `Modelo` varchar(255) NOT NULL COMMENT 'Modelo',
  `Color` varchar(255) NOT NULL COMMENT 'Color',
  `Observaciones_Articulo` varchar(255) NOT NULL COMMENT 'Observaciones del articulo'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Articulos del sistema';

-- --------------------------------------------------------

--
-- Table structure for table `caja`
--

CREATE TABLE `caja` (
  `Id_Caja` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Caja_Tipo` int(6) NOT NULL COMMENT 'Tipo de caja, define si es entrada o salida',
  `Importe_Caja` decimal(10,4) NOT NULL COMMENT 'De cuanto es el movimiento, siempre en pesos',
  `Fecha_Caja` datetime NOT NULL COMMENT 'Fecha del movimiento',
  `Numero_Remito_Caja` int(6) DEFAULT NULL COMMENT 'Numero del remito, si lo tiene',
  `Numero_Cuota_Caja` int(6) DEFAULT NULL COMMENT 'Numero de cuota de pago del remito',
  `Tag_Caja` varchar(255) DEFAULT NULL COMMENT 'Para almacenar datos de la aplicacion'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Se guarda todos las salidas y entradas de la caja en efectiv';

-- --------------------------------------------------------

--
-- Table structure for table `caja_tipo`
--

CREATE TABLE `caja_tipo` (
  `Id_Caja_Tipo` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Descripcion_Caja_Tipo` varchar(255) NOT NULL COMMENT 'Descripcion del tipo de caja, con esto se define si es entrada o salida'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Para saber que tipo de modificacion se le puede hacer a la c';

-- --------------------------------------------------------

--
-- Table structure for table `categoria`
--

CREATE TABLE `categoria` (
  `Id_Categoria` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Descripcion_Categoria` varchar(255) NOT NULL COMMENT 'Descripcion de la categoria'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Categorias de los articulos';

-- --------------------------------------------------------

--
-- Table structure for table `cheque_cartera`
--

CREATE TABLE `cheque_cartera` (
  `Id_Cheque_Cartera` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Localidad` int(6) NOT NULL COMMENT 'Localidad del cheque',
  `Codigo_Cheque_Cartera` varchar(255) NOT NULL COMMENT 'Numero, codigo del cheque',
  `Numero_Recibo_Cheque_Cartera` int(6) NOT NULL COMMENT 'Numero de recibo con el que entregaron el cheque',
  `Nombre_Cheque_Cartera` varchar(255) NOT NULL COMMENT 'Nombre del banco de donde sale el cheque',
  `Fecha_Emicion_Cheque_Cartera` datetime NOT NULL COMMENT 'Fecha de cuando se emite el cheque',
  `Fecha_Vencimiento_Cheque_Cartera` datetime NOT NULL COMMENT 'Cuando se vence',
  `Nombre_Librador_Cheque_Cartera` varchar(255) NOT NULL COMMENT 'Nombre del que libera el cheque',
  `Marca_Cheque_Cartera` bit(1) NOT NULL,
  `Importe_Cheque_Cartera` decimal(10,4) NOT NULL COMMENT 'Importe del cheque',
  `Detalle_Cheque_Cartera` varchar(255) NOT NULL COMMENT 'Algunos detalles sobre este cheque'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Cheques que entregan como forma de pago los clientes';

-- --------------------------------------------------------

--
-- Table structure for table `couta`
--

CREATE TABLE `couta` (
  `Id_Couta` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Factura` int(6) NOT NULL COMMENT 'ID de la factura',
  `Numero_Couta_Couta` int(6) NOT NULL COMMENT 'Numero de la cuota',
  `Fecha_Vencimineto_Couta` datetime NOT NULL COMMENT 'Fecha vencimiento',
  `Fecha_Pago_Couta` datetime NOT NULL COMMENT 'Fecha del pago de la cuota',
  `Importe_Couta` decimal(10,4) NOT NULL COMMENT 'Importe de la cuota',
  `Importe_Interes_Couta` decimal(10,4) NOT NULL COMMENT 'Este interes se agrecuando se pago fuera de termino',
  `Asignacion_Cuota` decimal(10,4) NOT NULL,
  `Pagado_Couta` bit(1) NOT NULL COMMENT 'Este campo es vendadero cuando esta cuota ya esta pagada',
  `Observaciones_Couta` varchar(255) NOT NULL COMMENT 'Algunas observaciones en el pago de la cuota'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Se lleva el control de las coutas';

-- --------------------------------------------------------

--
-- Table structure for table `documento`
--

CREATE TABLE `documento` (
  `Id_Documento` int(6) NOT NULL COMMENT 'Numero de documento de entrega',
  `Id_Factura` int(6) NOT NULL COMMENT 'Factura relacionada a la entrega de documentacion',
  `Fecha_Entrega_Documento` datetime NOT NULL COMMENT 'Fecha de entrega de documentacion',
  `Dominio_Documento` varchar(255) DEFAULT NULL,
  `Observaciones_Documento` varchar(255) NOT NULL COMMENT 'Algunas observaciones en la entrega de la documentacion'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Todas las entrega de documentacion de automotores';

-- --------------------------------------------------------

--
-- Table structure for table `empresa`
--

CREATE TABLE `empresa` (
  `Id_Empresa` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Localidad` int(6) NOT NULL COMMENT 'Localidad de la empresa',
  `Id_Tercero_IVA` int(6) NOT NULL COMMENT 'IVA de la empresa',
  `Razon_Social_Empresa` varchar(255) NOT NULL COMMENT 'Razon Social o nombre de la empresa',
  `Titular_Empresa` varchar(255) NOT NULL COMMENT 'Titular de due??o de la empresa',
  `CUIT_Empresa` varchar(13) NOT NULL COMMENT 'CUIT de la empresa',
  `Direccion_Empresa` varchar(255) NOT NULL COMMENT 'Direccion de la empresa',
  `Telefonos_Empresa` varchar(255) NOT NULL COMMENT 'Telefonos de la empresa',
  `Fax_Empresa` varchar(255) NOT NULL COMMENT 'Fax de la empresa',
  `Email_Empresa` varchar(255) NOT NULL COMMENT 'Email de la empresa',
  `Web_Empresa` varchar(255) NOT NULL COMMENT 'Web de la empresa',
  `Inicio_Actividades_Empresa` datetime NOT NULL COMMENT 'Cuando se inicio la actividad de la empresa',
  `Ingresos_Brutos_Empresa` varchar(255) NOT NULL COMMENT 'Ingresos brutos de la empresa'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Datos de la empresa';

-- --------------------------------------------------------

--
-- Table structure for table `factura`
--

CREATE TABLE `factura` (
  `Id_Factura` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Tercero` int(6) NOT NULL COMMENT 'ID del tercero responsable del comprobante',
  `Id_Factura_Tipo` int(6) NOT NULL COMMENT 'Tipo de factura',
  `Fecha_Factura` datetime NOT NULL COMMENT 'Facha en que se realiaza la factura',
  `Fecha_Vencimiento_Factura` datetime NOT NULL COMMENT 'Fecha de vencimiento de la factura',
  `Clase_Factura` varchar(1) NOT NULL COMMENT 'Clase de la factura',
  `Puesto_Factura` int(4) NOT NULL COMMENT 'Puesto de la factura',
  `Numero_Factura` int(8) NOT NULL COMMENT 'Numero de la factura',
  `Neto_Factura` decimal(10,4) NOT NULL COMMENT 'Valor total del Neto de la factura',
  `IVA_105_Factura` decimal(10,4) NOT NULL COMMENT 'Valor total de los articulos con IVA 10,5%',
  `IVA_21_Factura` decimal(10,4) NOT NULL COMMENT 'Valor total de los articulos con IVA 21%',
  `IVA_27_Factura` decimal(10,4) NOT NULL COMMENT 'Valor total de los articulos con IVA 27%',
  `Percepcion_Factura` decimal(10,4) NOT NULL COMMENT 'Valor de la percepcion',
  `Exentos_Factura` decimal(10,4) NOT NULL COMMENT 'Valor total de los articulos sin IVA',
  `Otros_Factura` decimal(10,4) NOT NULL COMMENT 'Otros valores, recargos, importes internos, etc.',
  `Total_Factura` decimal(10,4) NOT NULL COMMENT 'Total de la factura',
  `Retencion_Factura` decimal(10,4) NOT NULL COMMENT 'Retencion de la factura',
  `Interes_Factura` decimal(10,4) NOT NULL COMMENT 'Interes que se le agrega a las cuotas',
  `Anulado_Factura` bit(1) NOT NULL COMMENT 'Si es verdadero la factura esta anulada',
  `Facturado_Factura` bit(1) NOT NULL COMMENT 'Si es verdadero la factura esta facturada',
  `Pagado_Factura` bit(1) NOT NULL COMMENT 'Se usa para los proveedores, para saber cuando esta pagada la factura de compra',
  `Observaciones_Factura` varchar(255) NOT NULL COMMENT 'Observaciones de la factura'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Aca van todas las facturas';

-- --------------------------------------------------------

--
-- Table structure for table `factura_detalle`
--

CREATE TABLE `factura_detalle` (
  `Id_Factura_Detalle` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Factura` int(6) NOT NULL COMMENT 'Id de la factura',
  `Id_Articulo` int(6) NOT NULL COMMENT 'Id del articulo',
  `Cantidad_Factura_Detalle` int(6) NOT NULL COMMENT 'Cantidad de articulos',
  `Precio_Unitario_Factura_Detalle` decimal(10,4) NOT NULL COMMENT 'Precio unitario del articulo',
  `Bonifica_Factura_Detalle` decimal(10,4) NOT NULL COMMENT 'Bonificacion del articulo'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Detalle de la factura, los articulos.';

-- --------------------------------------------------------

--
-- Table structure for table `factura_garante`
--

CREATE TABLE `factura_garante` (
  `Id_Factura_Garante` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Factura` int(6) NOT NULL COMMENT 'id de la factura que va a salir de garantia',
  `Id_Tercero` int(6) NOT NULL COMMENT 'tercero garante'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Garante asociados a las facturas correspondiente';

-- --------------------------------------------------------

--
-- Table structure for table `factura_recibo_asignaciones`
--

CREATE TABLE `factura_recibo_asignaciones` (
  `Id_Factura_Recibo_Asignaciones` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Factura` int(6) NOT NULL COMMENT 'Factura, que seria el recibo u orden de pago a que se le van a asignar facturas',
  `Factura_Asignada_Factura_Recibo_Asignaciones` int(6) NOT NULL COMMENT 'factura que se le asigna a esta orden o recibo',
  `Impresa_Factura_Recibo_Asignaciones` bit(1) NOT NULL,
  `Det1_Factura_Recibo_Asignaciones` varchar(2) NOT NULL,
  `Importe_Factura_Recibo_Asignaciones` decimal(10,4) NOT NULL COMMENT 'Importe de lo que se le va a asignar a esta factura',
  `Importe_Descuento_Factura_Recibo_Asignaciones` decimal(10,4) NOT NULL COMMENT 'Descuento que tiene esta facturas'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Asignaciones que se le hacen a las facturas';

-- --------------------------------------------------------

--
-- Table structure for table `factura_recibo_detalle`
--

CREATE TABLE `factura_recibo_detalle` (
  `Id_Factura_Recibo_Detalle` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Factura` int(6) NOT NULL COMMENT 'Id de la orden de pago o recibo',
  `Id_Factura_Recibo_Tipo` int(6) NOT NULL COMMENT 'Tipo asignacion a este recibo u orden',
  `Importe_Factura_Recibo_Detalle` decimal(10,4) NOT NULL COMMENT 'Importe de la asignacion',
  `Importe_Descuento_Factura_Recibo_Detalle` decimal(10,4) NOT NULL COMMENT 'Algun descuento a la asignacion'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Detalle de los recibo y ordenes';

-- --------------------------------------------------------

--
-- Table structure for table `factura_recibo_tipo`
--

CREATE TABLE `factura_recibo_tipo` (
  `Id_Factura_Recibo_Tipo` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Descripcion_Factura_Recibo_Tipo` varchar(255) NOT NULL COMMENT 'Descripcion del tipo de recibo, es la forma de pago'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Tipo de pagos en recibos';

-- --------------------------------------------------------

--
-- Table structure for table `factura_tipo`
--

CREATE TABLE `factura_tipo` (
  `Id_Factura_Tipo` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Descripcion_Factura_Tipo` varchar(255) NOT NULL COMMENT 'Descripcion del tipo de factura',
  `Abreviacion_Factura_Tipo` varchar(4) NOT NULL COMMENT 'Abreviatura del tipo de factura'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Tipo de comprobantes';

-- --------------------------------------------------------

--
-- Table structure for table `historial_sql`
--

CREATE TABLE `historial_sql` (
  `Id_Historial_SQL` int(6) NOT NULL COMMENT 'ID de la tabla',
  `SQL_Historial_SQL` text NOT NULL COMMENT 'SQL que modifica la base de datos',
  `Fecha_Historial_SQL` datetime NOT NULL COMMENT 'Fecha y hora en que se ejecula la SQL',
  `IP_Historial_SQL` varchar(15) NOT NULL COMMENT 'IP de donde biene el SQL',
  `Nombre_Host_Historial_SQL` varchar(255) NOT NULL COMMENT 'Nombre del equipo'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Contiene todas las modificaciones que se hace en la base de ';

-- --------------------------------------------------------

--
-- Table structure for table `linea`
--

CREATE TABLE `linea` (
  `Id_Linea` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Descripcion_Linea` varchar(255) NOT NULL COMMENT 'Descripcion de la linea'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Linea de los articulos';

-- --------------------------------------------------------

--
-- Table structure for table `localidad`
--

CREATE TABLE `localidad` (
  `Id_Localidad` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Provincia` int(6) NOT NULL COMMENT 'ID de la provincia',
  `Nombre_Localidad` varchar(255) NOT NULL COMMENT 'Nombre de la localidad',
  `Codigo_Postal_Localidad` int(6) NOT NULL COMMENT 'Codigo postal de la localidad'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Ciudades del sistema';

-- --------------------------------------------------------

--
-- Table structure for table `pais`
--

CREATE TABLE `pais` (
  `Id_Pais` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Nombre_Pais` varchar(255) NOT NULL COMMENT 'Nombre del pais'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Paises del sistema';

-- --------------------------------------------------------

--
-- Table structure for table `provincia`
--

CREATE TABLE `provincia` (
  `Id_Provincia` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Pais` int(6) NOT NULL COMMENT 'Id del pais',
  `Nombre_Provincia` varchar(255) NOT NULL COMMENT 'Nombre de la provincia'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Provincias del sistema';

-- --------------------------------------------------------

--
-- Table structure for table `series`
--

CREATE TABLE `series` (
  `Comprobante` varchar(10) NOT NULL COMMENT 'Tipo de comprobantes',
  `Numero` int(8) NOT NULL COMMENT 'Numero de comprobante siguiente',
  `Bloqueado` bit(1) NOT NULL COMMENT 'Verdadero si esta bloqueado'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Lleva el control del los auto incrementos de los comprobante';

-- --------------------------------------------------------

--
-- Table structure for table `tercero`
--

CREATE TABLE `tercero` (
  `Id_Tercero` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Tercero_Tipo` int(6) NOT NULL COMMENT 'Para saber si proveedor o cliente',
  `Id_Tercero_IVA` int(6) NOT NULL COMMENT 'La condicion de iva del tercero',
  `Id_Localidad` int(6) NOT NULL COMMENT 'ID de la localidad de la aplicacion',
  `Razon_Social_Tercero` varchar(255) NOT NULL COMMENT 'Razon social, nombre y apellido del tercero',
  `Direccion_Tercero` varchar(255) NOT NULL COMMENT 'Direccion del tercero',
  `Fecha_Nacimiento_Tercero` datetime NOT NULL COMMENT 'Fecha de nacimiento',
  `CUIT_Tercero` varchar(13) NOT NULL COMMENT 'CUIT del tercero (por lo general a proveedores',
  `Telefonos_Tercero` varchar(255) NOT NULL COMMENT 'Telefonos del tercero',
  `DNI_Tercero` int(8) NOT NULL COMMENT 'DNI del tercero',
  `Fax_Tercero` varchar(255) NOT NULL COMMENT 'Fax del tercer',
  `Email_Tercero` varchar(255) NOT NULL COMMENT '"Email del tercero',
  `Fecha_Alta_Tercero` datetime NOT NULL COMMENT 'Fecha de alta del tercero',
  `Fecha_Baja_Tercero` datetime NOT NULL COMMENT 'Fecha de baja del tercero',
  `Anulado_Tercero` bit(1) NOT NULL COMMENT 'Es verdadero si esta anulado este tercero',
  `Observaciones_Tercero` varchar(255) NOT NULL COMMENT 'Observaciones del tercero'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Guarda los cliente y los proveedores';

-- --------------------------------------------------------

--
-- Table structure for table `tercero_iva`
--

CREATE TABLE `tercero_iva` (
  `Id_Tercero_IVA` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Descripcion_Tercero_IVA` varchar(255) NOT NULL COMMENT 'Descripcion del tipo de iva/ condicion del tercero',
  `Abreviacion_Tercero_IVA` varchar(3) NOT NULL COMMENT 'Abreviatura del la descripcion',
  `Clase_Comprobante_Compra_Tercero_IVA` varchar(1) NOT NULL COMMENT 'Clase que se usa para este tipo de iva en la compra',
  `Clase_Comprobante_Venta_Tercero_IVA` varchar(1) NOT NULL COMMENT 'Clase que se usa para este tipo de iva en la venta'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Tipo de condicion de IVA';

-- --------------------------------------------------------

--
-- Table structure for table `tercero_tipo`
--

CREATE TABLE `tercero_tipo` (
  `Id_Tercero_Tipo` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Descripcion_Tercero_Tipo` varchar(255) NOT NULL COMMENT 'Descripcion del tipo de tipo de tercero'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Para saber si es proveedor o cliente';

--
-- Indexes for dumped tables
--

--
-- Indexes for table `articulo`
--
ALTER TABLE `articulo`
  ADD PRIMARY KEY (`Id_Articulo`),
  ADD KEY `articulo_linea` (`Id_Linea`),
  ADD KEY `articulo_categoria` (`Id_Categoria`),
  ADD KEY `articulo_tercero` (`Id_Tercero`);

--
-- Indexes for table `caja`
--
ALTER TABLE `caja`
  ADD PRIMARY KEY (`Id_Caja`),
  ADD KEY `caja_caja_tipo` (`Id_Caja_Tipo`);

--
-- Indexes for table `caja_tipo`
--
ALTER TABLE `caja_tipo`
  ADD PRIMARY KEY (`Id_Caja_Tipo`);

--
-- Indexes for table `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`Id_Categoria`);

--
-- Indexes for table `cheque_cartera`
--
ALTER TABLE `cheque_cartera`
  ADD PRIMARY KEY (`Id_Cheque_Cartera`),
  ADD KEY `cheque_cartera_localidad` (`Id_Localidad`);

--
-- Indexes for table `couta`
--
ALTER TABLE `couta`
  ADD PRIMARY KEY (`Id_Couta`),
  ADD KEY `couta_factura` (`Id_Factura`);

--
-- Indexes for table `documento`
--
ALTER TABLE `documento`
  ADD PRIMARY KEY (`Id_Documento`),
  ADD KEY `documento_factura` (`Id_Factura`);

--
-- Indexes for table `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`Id_Empresa`),
  ADD KEY `empresa_localidad` (`Id_Localidad`),
  ADD KEY `empresa_tercero_iva` (`Id_Tercero_IVA`);

--
-- Indexes for table `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`Id_Factura`),
  ADD KEY `factura_tercero` (`Id_Tercero`),
  ADD KEY `factura_factura_tipo` (`Id_Factura_Tipo`);

--
-- Indexes for table `factura_detalle`
--
ALTER TABLE `factura_detalle`
  ADD PRIMARY KEY (`Id_Factura_Detalle`),
  ADD KEY `factura_detalle_factura` (`Id_Factura`),
  ADD KEY `factura_detalle_articulo` (`Id_Articulo`);

--
-- Indexes for table `factura_garante`
--
ALTER TABLE `factura_garante`
  ADD PRIMARY KEY (`Id_Factura_Garante`),
  ADD KEY `factura_garante_factura` (`Id_Factura`),
  ADD KEY `factura_garante_tercero` (`Id_Tercero`);

--
-- Indexes for table `factura_recibo_asignaciones`
--
ALTER TABLE `factura_recibo_asignaciones`
  ADD PRIMARY KEY (`Id_Factura_Recibo_Asignaciones`),
  ADD KEY `factura_recibo_asignaciones_factura` (`Id_Factura`);

--
-- Indexes for table `factura_recibo_detalle`
--
ALTER TABLE `factura_recibo_detalle`
  ADD PRIMARY KEY (`Id_Factura_Recibo_Detalle`),
  ADD KEY `factura_recibo_detalle_factura` (`Id_Factura`),
  ADD KEY `factura_recibo_detalle_factura_recibo_tipo` (`Id_Factura_Recibo_Tipo`);

--
-- Indexes for table `factura_recibo_tipo`
--
ALTER TABLE `factura_recibo_tipo`
  ADD PRIMARY KEY (`Id_Factura_Recibo_Tipo`);

--
-- Indexes for table `factura_tipo`
--
ALTER TABLE `factura_tipo`
  ADD PRIMARY KEY (`Id_Factura_Tipo`);

--
-- Indexes for table `historial_sql`
--
ALTER TABLE `historial_sql`
  ADD PRIMARY KEY (`Id_Historial_SQL`);

--
-- Indexes for table `linea`
--
ALTER TABLE `linea`
  ADD PRIMARY KEY (`Id_Linea`);

--
-- Indexes for table `localidad`
--
ALTER TABLE `localidad`
  ADD PRIMARY KEY (`Id_Localidad`),
  ADD KEY `localidad_provincia` (`Id_Provincia`);

--
-- Indexes for table `pais`
--
ALTER TABLE `pais`
  ADD PRIMARY KEY (`Id_Pais`);

--
-- Indexes for table `provincia`
--
ALTER TABLE `provincia`
  ADD PRIMARY KEY (`Id_Provincia`),
  ADD KEY `provincia_pais` (`Id_Pais`);

--
-- Indexes for table `tercero`
--
ALTER TABLE `tercero`
  ADD PRIMARY KEY (`Id_Tercero`),
  ADD KEY `tercero_tercero_tipo` (`Id_Tercero_Tipo`),
  ADD KEY `tercero_tercero_iva` (`Id_Tercero_IVA`),
  ADD KEY `tercero_localidad` (`Id_Localidad`);

--
-- Indexes for table `tercero_iva`
--
ALTER TABLE `tercero_iva`
  ADD PRIMARY KEY (`Id_Tercero_IVA`);

--
-- Indexes for table `tercero_tipo`
--
ALTER TABLE `tercero_tipo`
  ADD PRIMARY KEY (`Id_Tercero_Tipo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `articulo`
--
ALTER TABLE `articulo`
  MODIFY `Id_Articulo` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `caja`
--
ALTER TABLE `caja`
  MODIFY `Id_Caja` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `caja_tipo`
--
ALTER TABLE `caja_tipo`
  MODIFY `Id_Caja_Tipo` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `categoria`
--
ALTER TABLE `categoria`
  MODIFY `Id_Categoria` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `cheque_cartera`
--
ALTER TABLE `cheque_cartera`
  MODIFY `Id_Cheque_Cartera` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `couta`
--
ALTER TABLE `couta`
  MODIFY `Id_Couta` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `documento`
--
ALTER TABLE `documento`
  MODIFY `Id_Documento` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Numero de documento de entrega';

--
-- AUTO_INCREMENT for table `empresa`
--
ALTER TABLE `empresa`
  MODIFY `Id_Empresa` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `factura`
--
ALTER TABLE `factura`
  MODIFY `Id_Factura` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `factura_detalle`
--
ALTER TABLE `factura_detalle`
  MODIFY `Id_Factura_Detalle` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `factura_garante`
--
ALTER TABLE `factura_garante`
  MODIFY `Id_Factura_Garante` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `factura_recibo_asignaciones`
--
ALTER TABLE `factura_recibo_asignaciones`
  MODIFY `Id_Factura_Recibo_Asignaciones` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `factura_recibo_detalle`
--
ALTER TABLE `factura_recibo_detalle`
  MODIFY `Id_Factura_Recibo_Detalle` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `factura_recibo_tipo`
--
ALTER TABLE `factura_recibo_tipo`
  MODIFY `Id_Factura_Recibo_Tipo` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `factura_tipo`
--
ALTER TABLE `factura_tipo`
  MODIFY `Id_Factura_Tipo` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `historial_sql`
--
ALTER TABLE `historial_sql`
  MODIFY `Id_Historial_SQL` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `linea`
--
ALTER TABLE `linea`
  MODIFY `Id_Linea` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `localidad`
--
ALTER TABLE `localidad`
  MODIFY `Id_Localidad` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `pais`
--
ALTER TABLE `pais`
  MODIFY `Id_Pais` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `provincia`
--
ALTER TABLE `provincia`
  MODIFY `Id_Provincia` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `tercero`
--
ALTER TABLE `tercero`
  MODIFY `Id_Tercero` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `tercero_iva`
--
ALTER TABLE `tercero_iva`
  MODIFY `Id_Tercero_IVA` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `tercero_tipo`
--
ALTER TABLE `tercero_tipo`
  MODIFY `Id_Tercero_Tipo` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- Constraints for dumped tables
--

--
-- Constraints for table `articulo`
--
ALTER TABLE `articulo`
  ADD CONSTRAINT `articulo_categoria` FOREIGN KEY (`Id_Categoria`) REFERENCES `categoria` (`Id_Categoria`),
  ADD CONSTRAINT `articulo_linea` FOREIGN KEY (`Id_Linea`) REFERENCES `linea` (`Id_Linea`),
  ADD CONSTRAINT `articulo_tercero` FOREIGN KEY (`Id_Tercero`) REFERENCES `tercero` (`Id_Tercero`);

--
-- Constraints for table `caja`
--
ALTER TABLE `caja`
  ADD CONSTRAINT `caja_caja_tipo` FOREIGN KEY (`Id_Caja_Tipo`) REFERENCES `caja_tipo` (`Id_Caja_Tipo`);

--
-- Constraints for table `cheque_cartera`
--
ALTER TABLE `cheque_cartera`
  ADD CONSTRAINT `cheque_cartera_localidad` FOREIGN KEY (`Id_Localidad`) REFERENCES `localidad` (`Id_Localidad`);

--
-- Constraints for table `couta`
--
ALTER TABLE `couta`
  ADD CONSTRAINT `couta_factura` FOREIGN KEY (`Id_Factura`) REFERENCES `factura` (`Id_Factura`);

--
-- Constraints for table `documento`
--
ALTER TABLE `documento`
  ADD CONSTRAINT `documento_factura` FOREIGN KEY (`Id_Factura`) REFERENCES `factura` (`Id_Factura`);

--
-- Constraints for table `empresa`
--
ALTER TABLE `empresa`
  ADD CONSTRAINT `empresa_localidad` FOREIGN KEY (`Id_Localidad`) REFERENCES `localidad` (`Id_Localidad`),
  ADD CONSTRAINT `empresa_tercero_iva` FOREIGN KEY (`Id_Tercero_IVA`) REFERENCES `tercero_iva` (`Id_Tercero_IVA`);

--
-- Constraints for table `factura`
--
ALTER TABLE `factura`
  ADD CONSTRAINT `factura_factura_tipo` FOREIGN KEY (`Id_Factura_Tipo`) REFERENCES `factura_tipo` (`Id_Factura_Tipo`),
  ADD CONSTRAINT `factura_tercero` FOREIGN KEY (`Id_Tercero`) REFERENCES `tercero` (`Id_Tercero`);

--
-- Constraints for table `factura_detalle`
--
ALTER TABLE `factura_detalle`
  ADD CONSTRAINT `factura_detalle_articulo` FOREIGN KEY (`Id_Articulo`) REFERENCES `articulo` (`Id_Articulo`),
  ADD CONSTRAINT `factura_detalle_factura` FOREIGN KEY (`Id_Factura`) REFERENCES `factura` (`Id_Factura`);

--
-- Constraints for table `factura_garante`
--
ALTER TABLE `factura_garante`
  ADD CONSTRAINT `factura_garante_factura` FOREIGN KEY (`Id_Factura`) REFERENCES `factura` (`Id_Factura`),
  ADD CONSTRAINT `factura_garante_tercero` FOREIGN KEY (`Id_Tercero`) REFERENCES `tercero` (`Id_Tercero`);

--
-- Constraints for table `factura_recibo_asignaciones`
--
ALTER TABLE `factura_recibo_asignaciones`
  ADD CONSTRAINT `factura_recibo_asignaciones_factura` FOREIGN KEY (`Id_Factura`) REFERENCES `factura` (`Id_Factura`);

--
-- Constraints for table `factura_recibo_detalle`
--
ALTER TABLE `factura_recibo_detalle`
  ADD CONSTRAINT `factura_recibo_detalle_factura` FOREIGN KEY (`Id_Factura`) REFERENCES `factura` (`Id_Factura`),
  ADD CONSTRAINT `factura_recibo_detalle_factura_recibo_tipo` FOREIGN KEY (`Id_Factura_Recibo_Tipo`) REFERENCES `factura_recibo_tipo` (`Id_Factura_Recibo_Tipo`);

--
-- Constraints for table `localidad`
--
ALTER TABLE `localidad`
  ADD CONSTRAINT `localidad_provincia` FOREIGN KEY (`Id_Provincia`) REFERENCES `provincia` (`Id_Provincia`);

--
-- Constraints for table `provincia`
--
ALTER TABLE `provincia`
  ADD CONSTRAINT `provincia_pais` FOREIGN KEY (`Id_Pais`) REFERENCES `pais` (`Id_Pais`);

--
-- Constraints for table `tercero`
--
ALTER TABLE `tercero`
  ADD CONSTRAINT `tercero_localidad` FOREIGN KEY (`Id_Localidad`) REFERENCES `localidad` (`Id_Localidad`),
  ADD CONSTRAINT `tercero_tercero_iva` FOREIGN KEY (`Id_Tercero_IVA`) REFERENCES `tercero_iva` (`Id_Tercero_IVA`),
  ADD CONSTRAINT `tercero_tercero_tipo` FOREIGN KEY (`Id_Tercero_Tipo`) REFERENCES `tercero_tipo` (`Id_Tercero_Tipo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
