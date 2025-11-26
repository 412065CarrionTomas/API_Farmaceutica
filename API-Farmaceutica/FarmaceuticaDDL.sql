-- Opcional: crear base de datos y conectarse
-- CREATE DATABASE farmaceutica;
-- \c farmaceutica;

-- 1. tipos_documentos
CREATE TABLE tipos_documentos (
    tipo_documentoid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(250)
);

-- 2. paises
CREATE TABLE paises (
    paisid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripciones VARCHAR(200)
);

-- 3. provincias
CREATE TABLE provincias (
    provinciaid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    paisid INT NOT NULL,
    descripcion VARCHAR(200),
    CONSTRAINT fk_provincias_paises FOREIGN KEY (paisid) REFERENCES paises(paisid)
);

-- 4. localidades
CREATE TABLE localidades (
    localidadid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(250),
    provinciaid INT,
    CONSTRAINT fk_localidades_provincias FOREIGN KEY (provinciaid) REFERENCES provincias(provinciaid)
);

-- 5. tipos_presentaciones
CREATE TABLE tipos_presentaciones (
    tipo_presentacionid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(200)
);

-- 6. unidades_medidas
CREATE TABLE unidades_medidas (
    unidad_medidaid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(200)
);

-- 7. tipos_suministros
CREATE TABLE tipos_suministros (
    tipo_suministroid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(200)
);

-- 8. clasificaciones_suministros
CREATE TABLE clasificaciones_suministros (
    clasificacion_suministroid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(200)
);

-- 9. restricciones
CREATE TABLE restricciones (
    restriccionid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(250)
);

-- 10. tipos_descuentos
CREATE TABLE tipos_descuentos (
    tipo_descuentoid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(250)
);

-- 11. metodos_pagos
CREATE TABLE metodos_pagos (
    metodo_pagoid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(200)
);

-- 12. especialidades_medicos
CREATE TABLE especialidades_medicos (
    especialidadid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    nombre_especialidad VARCHAR(250)
);

-- 13. obras_sociales
CREATE TABLE obras_sociales (
    obra_socialid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(250)
);

-- 14. planes_obras_sociales
CREATE TABLE planes_obras_sociales (
    plan_obra_socialid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(250),
    obra_socialid INT NOT NULL,
    CONSTRAINT fk_plan_obra_obra_social FOREIGN KEY (obra_socialid) REFERENCES obras_sociales(obra_socialid)
);

-- 15. proveedores
CREATE TABLE proveedores (
    proveedorid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    razonsocial VARCHAR(250),
    cuit VARCHAR(50),
    direccionproveedor VARCHAR(500),
    telefonoproveedor VARCHAR(50),
    emailproveedor VARCHAR(250)
);

-- 16. repartidores
CREATE TABLE repartidores (
    repartidorid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    nombrerepartidor VARCHAR(250),
    apellidorepartidor VARCHAR(250),
    telefonorepartidor VARCHAR(50),
    emailrepartidor VARCHAR(250)
);

-- 17. sucursales
CREATE TABLE sucursales (
    sucursalid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(250),
    direccion VARCHAR(500),
    localidadid INT,
    CONSTRAINT fk_sucursales_localidades FOREIGN KEY (localidadid) REFERENCES localidades(localidadid)
);

-- 18. productos
CREATE TABLE productos (
    productoid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    codigo_barra_productoid VARCHAR(150),
    nombre_producto VARCHAR(400),
    precio_producto DECIMAL(12,2),
    tipo_suministroid INT,
    clasificacion_suministroid INT,
    unidad_medidaid INT,
    tipo_presentacionid INT,
    CONSTRAINT fk_productos_tipos_suministro FOREIGN KEY (tipo_suministroid) REFERENCES tipos_suministros(tipo_suministroid),
    CONSTRAINT fk_productos_clasificacion FOREIGN KEY (clasificacion_suministroid) REFERENCES clasificaciones_suministros(clasificacion_suministroid),
    CONSTRAINT fk_productos_unidad_medida FOREIGN KEY (unidad_medidaid) REFERENCES unidades_medidas(unidad_medidaid),
    CONSTRAINT fk_productos_tipo_presentacion FOREIGN KEY (tipo_presentacionid) REFERENCES tipos_presentaciones(tipo_presentacionid)
);

-- 19. medicamentos
CREATE TABLE medicamentos (
    medicamentoid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    codigo_barra_medicamentoid VARCHAR(150),
    nombre_medicamento VARCHAR(400),
    precio_medicamento DECIMAL(12,2),
    unidad_medidaid INT,
    tipo_presentacionid INT,
    clasificacion_suministroid INT,
    tipo_suministroid INT,
    restriccionid INT,
    CONSTRAINT fk_medicamentos_unidad_medida FOREIGN KEY (unidad_medidaid) REFERENCES unidades_medidas(unidad_medidaid),
    CONSTRAINT fk_medicamentos_tipo_presentacion FOREIGN KEY (tipo_presentacionid) REFERENCES tipos_presentaciones(tipo_presentacionid),
    CONSTRAINT fk_medicamentos_clasificacion FOREIGN KEY (clasificacion_suministroid) REFERENCES clasificaciones_suministros(clasificacion_suministroid),
    CONSTRAINT fk_medicamentos_tipos_suministro FOREIGN KEY (tipo_suministroid) REFERENCES tipos_suministros(tipo_suministroid),
    CONSTRAINT fk_medicamentos_restricciones FOREIGN KEY (restriccionid) REFERENCES restricciones(restriccionid)
);

-- 20. lotes_productos
CREATE TABLE lotes_productos (
    lote_productoid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    fecha_vencimiento TIMESTAMP(3),
    fecha_elaboracion TIMESTAMP(3),
    cantidad BIGINT,
    productoid INT,
    CONSTRAINT fk_lotesprod_productos FOREIGN KEY (productoid) REFERENCES productos(productoid)
);

-- 21. lotes_medicamentos
CREATE TABLE lotes_medicamentos (
    lote_medicamentoid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    medicamentoid INT,
    fecha_vencimiento TIMESTAMP(3),
    fecha_elaboracion TIMESTAMP(3),
    cantidad BIGINT,
    CONSTRAINT fk_lotesmed_medicamentos FOREIGN KEY (medicamentoid) REFERENCES medicamentos(medicamentoid)
);

-- 22. clientes
CREATE TABLE clientes (
    clienteid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    nombrecliente VARCHAR(250),
    apellidocliente VARCHAR(250),
    fecha_nacimiento_cliente DATE,
    telefonocliente VARCHAR(50),
    tipo_documentoid INT,
    direccioncliente VARCHAR(500),
    localidadid INT,
    emailcliente VARCHAR(250),
    documentocliente VARCHAR(100),
    CONSTRAINT fk_clientes_tipos_documentos FOREIGN KEY (tipo_documentoid) REFERENCES tipos_documentos(tipo_documentoid),
    CONSTRAINT fk_clientes_localidades FOREIGN KEY (localidadid) REFERENCES localidades(localidadid)
);

-- 23. empleados
CREATE TABLE empleados (
    empleadoid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    nombreempleado VARCHAR(250),
    apellidoempleado VARCHAR(250),
    fecha_nacimiento_empleado DATE,
    direccionempleado VARCHAR(500),
    telefonoempleado VARCHAR(50),
    emailempleado VARCHAR(250),
    localidadid INT,
    tipo_documentoid INT,
    documentoempleado VARCHAR(100),
    CONSTRAINT fk_empleados_tipos_doc FOREIGN KEY (tipo_documentoid) REFERENCES tipos_documentos(tipo_documentoid),
    CONSTRAINT fk_empleados_localidades FOREIGN KEY (localidadid) REFERENCES localidades(localidadid)
);

-- 24. afiliados
CREATE TABLE afiliados (
    afiliadoid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    plan_obra_socialid INT NOT NULL,
    clienteid INT NOT NULL,
    CONSTRAINT fk_afiliados_plan_obra FOREIGN KEY (plan_obra_socialid) REFERENCES planes_obras_sociales(plan_obra_socialid),
    CONSTRAINT fk_afiliados_clientes FOREIGN KEY (clienteid) REFERENCES clientes(clienteid)
);

-- 25. doctores
CREATE TABLE doctores (
    doctorid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    nombre_doctor VARCHAR(250),
    apellido_doctor VARCHAR(250),
    matricula_doctor VARCHAR(100),
    especialidadid INT,
    CONSTRAINT fk_doctores_especialidades FOREIGN KEY (especialidadid) REFERENCES especialidades_medicos(especialidadid)
);

-- 26. recetas
CREATE TABLE recetas (
    recetaid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    fecha TIMESTAMP(3),
    afiliadoid INT,
    doctorid INT,
    CONSTRAINT fk_recetas_afiliados FOREIGN KEY (afiliadoid) REFERENCES afiliados(afiliadoid),
    CONSTRAINT fk_recetas_doctores FOREIGN KEY (doctorid) REFERENCES doctores(doctorid)
);

-- 27. estados_coberturas
CREATE TABLE estados_coberturas (
    estado_coberturaid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descripcion VARCHAR(250)
);

-- 28. coberturas
CREATE TABLE coberturas (
    coberturaid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    validacion_obra_social BOOLEAN NOT NULL DEFAULT FALSE,
    estado_coberturaid INT,
    afiliadoid INT,
    recetaid INT,
    CONSTRAINT fk_coberturas_estados FOREIGN KEY (estado_coberturaid) REFERENCES estados_coberturas(estado_coberturaid),
    CONSTRAINT fk_coberturas_afiliados FOREIGN KEY (afiliadoid) REFERENCES afiliados(afiliadoid),
    CONSTRAINT fk_coberturas_recetas FOREIGN KEY (recetaid) REFERENCES recetas(recetaid)
);

-- 29. detalles_recetas
CREATE TABLE detalles_recetas (
    detalle_recetaid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    recetaid INT NOT NULL,
    cantidad INT NOT NULL,
    medicamentoid INT,
    CONSTRAINT fk_detrecetas_recetas FOREIGN KEY (recetaid) REFERENCES recetas(recetaid),
    CONSTRAINT fk_detrecetas_medicamentos FOREIGN KEY (medicamentoid) REFERENCES medicamentos(medicamentoid)
);

-- 30. descuentos
CREATE TABLE descuentos (
    descuentoid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    localidadid INT,
    fecha_descuento TIMESTAMP(3),
    tipo_suministroid INT,
    obra_socialid INT,
    porcentaje_descuento DECIMAL(12,2),
    tipo_descuentoid INT,
    CONSTRAINT fk_descuentos_tiposdescuento FOREIGN KEY (tipo_descuentoid) REFERENCES tipos_descuentos(tipo_descuentoid),
    CONSTRAINT fk_descuentos_tiposuministro FOREIGN KEY (tipo_suministroid) REFERENCES tipos_suministros(tipo_suministroid),
    CONSTRAINT fk_descuentos_obras_sociales FOREIGN KEY (obra_socialid) REFERENCES obras_sociales(obra_socialid),
    CONSTRAINT fk_descuentos_localidades FOREIGN KEY (localidadid) REFERENCES localidades(localidadid)
);

-- 31. facturas
CREATE TABLE facturas (
    facturaid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    fecha_facturacion TIMESTAMP(3),
    empleadoid INT,
    clienteid INT,
    sucursalid INT,
    metodo_pagoid INT,
    CONSTRAINT fk_facturas_empleados FOREIGN KEY (empleadoid) REFERENCES empleados(empleadoid),
    CONSTRAINT fk_facturas_clientes FOREIGN KEY (clienteid) REFERENCES clientes(clienteid),
    CONSTRAINT fk_facturas_sucursales FOREIGN KEY (sucursalid) REFERENCES sucursales(sucursalid),
    CONSTRAINT fk_facturas_metodos_pago FOREIGN KEY (metodo_pagoid) REFERENCES metodos_pagos(metodo_pagoid)
);

-- 32. detalles_facturas
CREATE TABLE detalles_facturas (
    nro_detalleid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    descuentoid INT,
    productoid INT,
    medicamentoid INT,
    cantidad INT NOT NULL,
    precio DECIMAL(12,2),
    coberturaid INT,
    facturaid INT,
    CONSTRAINT fk_detfac_descuentos FOREIGN KEY (descuentoid) REFERENCES descuentos(descuentoid),
    CONSTRAINT fk_detfac_productos FOREIGN KEY (productoid) REFERENCES productos(productoid),
    CONSTRAINT fk_detfac_medicamentos FOREIGN KEY (medicamentoid) REFERENCES medicamentos(medicamentoid),
    CONSTRAINT fk_detfac_coberturas FOREIGN KEY (coberturaid) REFERENCES coberturas(coberturaid),
    CONSTRAINT fk_detfac_facturas FOREIGN KEY (facturaid) REFERENCES facturas(facturaid)
);

-- 33. compras
CREATE TABLE compras (
    compraid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    fecha_compra TIMESTAMP(3),
    empleadoid INT,
    proveedorid INT,
    repartidorid INT,
    sucursalid INT,
    CONSTRAINT fk_compras_proveedores FOREIGN KEY (proveedorid) REFERENCES proveedores(proveedorid),
    CONSTRAINT fk_compras_repartidores FOREIGN KEY (repartidorid) REFERENCES repartidores(repartidorid),
    CONSTRAINT fk_compras_sucursales FOREIGN KEY (sucursalid) REFERENCES sucursales(sucursalid),
    CONSTRAINT fk_compras_empleados FOREIGN KEY (empleadoid) REFERENCES empleados(empleadoid)
);

-- 34. detalles_compras
CREATE TABLE detalles_compras (
    detalle_compraid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    compraid INT NOT NULL,
    lote_productoid INT,
    codigo_barra_medicamentoid VARCHAR(150),
    codigo_barra_productoid VARCHAR(150),
    cantidad INT NOT NULL,
    lote_medicamentoid INT,
    CONSTRAINT fk_detallescompras_compras FOREIGN KEY (compraid) REFERENCES compras(compraid),
    CONSTRAINT fk_detallescompras_loteprod FOREIGN KEY (lote_productoid) REFERENCES lotes_productos(lote_productoid),
    CONSTRAINT fk_detallescompras_lotemed FOREIGN KEY (lote_medicamentoid) REFERENCES lotes_medicamentos(lote_medicamentoid)
);

-- 35. inventarios_productos
CREATE TABLE inventarios_productos (
    inventarios_productosid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    sucursalid INT,
    productoid INT,
    stock_minimo INT,
    stock_actual BIGINT,
    CONSTRAINT fk_invprod_sucursal FOREIGN KEY (sucursalid) REFERENCES sucursales(sucursalid),
    CONSTRAINT fk_invprod_productos FOREIGN KEY (productoid) REFERENCES productos(productoid)
);

-- 36. inventarios_medicamentos
CREATE TABLE inventarios_medicamentos (
    inventario_medicamentoid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    sucursalid INT,
    medicamentoid INT,
    stock_minimo INT,
    stock_actual BIGINT,
    CONSTRAINT fk_invmed_sucursal FOREIGN KEY (sucursalid) REFERENCES sucursales(sucursalid),
    CONSTRAINT fk_invmed_medicamentos FOREIGN KEY (medicamentoid) REFERENCES medicamentos(medicamentoid)
);

-- 37. empleados_sucursales
CREATE TABLE empleados_sucursales (
    empleado_sucursalid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    empleadoid INT NOT NULL,
    sucursalid INT NOT NULL,
    fecha_inicio TIMESTAMP(3),
    fecha_fin TIMESTAMP(3),
    CONSTRAINT fk_empsuc_empleados FOREIGN KEY (empleadoid) REFERENCES empleados(empleadoid),
    CONSTRAINT fk_empsuc_sucursales FOREIGN KEY (sucursalid) REFERENCES sucursales(sucursalid)
);

-- Columnas 'activo' agregadas
ALTER TABLE compras ADD COLUMN activo BOOLEAN;
ALTER TABLE detalles_compras ADD COLUMN activo BOOLEAN;
ALTER TABLE proveedores ADD COLUMN activo BOOLEAN;
ALTER TABLE medicamentos ADD COLUMN activo BOOLEAN;
ALTER TABLE productos ADD COLUMN activo BOOLEAN;
ALTER TABLE inventarios_medicamentos ADD COLUMN activo BOOLEAN;
ALTER TABLE inventarios_productos ADD COLUMN activo BOOLEAN;

-- Vistas
CREATE OR REPLACE VIEW vwmedicamentotop AS
SELECT m.nombre_medicamento AS nombre,
       m.codigo_barra_medicamentoid AS codigodebarra,
       df.precio AS precioventa,
       s.descripcion AS sucursal,
       SUM(df.cantidad) AS cantidadvendidatotal
FROM detalles_facturas df
JOIN facturas f ON f.facturaid = df.facturaid
JOIN medicamentos m ON m.medicamentoid = df.medicamentoid
JOIN sucursales s ON s.sucursalid = f.sucursalid
WHERE df.productoid IS NULL
GROUP BY m.nombre_medicamento, m.codigo_barra_medicamentoid, df.precio, s.descripcion
ORDER BY cantidadvendidatotal DESC
LIMIT 3;

CREATE OR REPLACE VIEW vwproductotop AS
SELECT p.nombre_producto AS nombre,
       p.codigo_barra_productoid AS codigodebarra,
       df.precio AS precioventa,
       s.descripcion AS sucursal,
       SUM(df.cantidad) AS cantidadvendidatotal
FROM detalles_facturas df
JOIN facturas f ON f.facturaid = df.facturaid
JOIN productos p ON p.productoid = df.productoid
JOIN sucursales s ON s.sucursalid = f.sucursalid
WHERE df.medicamentoid IS NULL
GROUP BY p.nombre_producto, p.codigo_barra_productoid, df.precio, s.descripcion
ORDER BY cantidadvendidatotal DESC
LIMIT 3;

-- Función equivalente a sp_TraerTablas
CREATE OR REPLACE FUNCTION sp_traer_tablas(
    empleado_dni VARCHAR,
    proveedor VARCHAR,
    repartidor VARCHAR,
    sucursal VARCHAR
) RETURNS TABLE (
    empleadoid INT,
    proveedorid INT,
    repartidorid INT,
    sucursalid INT
) LANGUAGE plpgsql AS $$
BEGIN
    RETURN QUERY
    SELECT
        (SELECT e.empleadoid FROM empleados e WHERE e.documentoempleado = empleado_dni),
        (SELECT p.proveedorid FROM proveedores p WHERE p.razonsocial = proveedor),
        (SELECT r.repartidorid FROM repartidores r WHERE r.emailrepartidor = repartidor),
        (SELECT s.sucursalid FROM sucursales s WHERE s.descripcion = sucursal);
END;
$$;

-- Función equivalente a sp_TraerTablasDetalle
CREATE OR REPLACE FUNCTION sp_traer_tablas_detalle(
    codigobarraproducto VARCHAR,
    codigobarramedicamento VARCHAR,
    lotemedicamento INT,
    loteproducto INT
) RETURNS TABLE (
    codigobarraproductoreturn VARCHAR,
    codigobarramedicamentoreturn VARCHAR,
    lotemedicamentoreturn INT,
    loteproductoreturn INT
) LANGUAGE plpgsql AS $$
BEGIN
    RETURN QUERY
    SELECT
        (SELECT p.codigo_barra_productoid FROM productos p WHERE p.codigo_barra_productoid = codigobarraproducto),
        (SELECT m.codigo_barra_medicamentoid FROM medicamentos m WHERE m.codigo_barra_medicamentoid = codigobarramedicamento),
        (SELECT lm.lote_medicamentoid FROM lotes_medicamentos lm WHERE lm.lote_medicamentoid = lotemedicamento),
        (SELECT lp.lote_productoid FROM lotes_productos lp WHERE lp.lote_productoid = loteproducto);
END;
$$;

-- Función equivalente a sp_ganancias_mensuales
CREATE OR REPLACE FUNCTION sp_ganancias_mensuales(anio INT)
RETURNS TABLE (
    mes INT,
    anio_result INT,
    importe NUMERIC(14,2)
) LANGUAGE sql AS $$
    SELECT EXTRACT(MONTH FROM f.fecha_facturacion)::INT AS mes,
           EXTRACT(YEAR FROM f.fecha_facturacion)::INT AS anio_result,
           SUM(df.precio * df.cantidad)::NUMERIC(14,2) AS importe
    FROM detalles_facturas df
    JOIN facturas f ON f.facturaid = df.facturaid
    WHERE EXTRACT(YEAR FROM f.fecha_facturacion) = anio
    GROUP BY EXTRACT(MONTH FROM f.fecha_facturacion), EXTRACT(YEAR FROM f.fecha_facturacion)
    ORDER BY mes DESC;
$$;

-- Función equivalente a sp_VentasPorSucursal
CREATE OR REPLACE FUNCTION sp_ventas_por_sucursal(anio INT)
RETURNS TABLE (
    sucursal VARCHAR,
    cantidadsucursal BIGINT,
    porcentaje DECIMAL(5,2)
) LANGUAGE sql AS $$
    WITH totales AS (
        SELECT COUNT(*) AS totalfacturas
        FROM facturas
        WHERE EXTRACT(YEAR FROM fecha_facturacion) = anio
    )
    SELECT s.descripcion AS sucursal,
           COUNT(f.facturaid) AS cantidadsucursal,
           (COUNT(f.facturaid) * 100.0 / t.totalfacturas)::DECIMAL(5,2) AS porcentaje
    FROM facturas f
    JOIN sucursales s ON f.sucursalid = s.sucursalid
    CROSS JOIN totales t
    WHERE EXTRACT(YEAR FROM f.fecha_facturacion) = anio
    GROUP BY s.descripcion, t.totalfacturas
    ORDER BY porcentaje DESC;
$$;

-- Función equivalente a sp_MPUsados
CREATE OR REPLACE FUNCTION sp_mpusados(anio INT)
RETURNS TABLE (
    metodo_pago VARCHAR,
    cantidadmpusado BIGINT,
    porcentaje DECIMAL(5,2)
) LANGUAGE sql AS $$
    WITH totales AS (
        SELECT COUNT(*) AS totalfacturas
        FROM facturas
        WHERE EXTRACT(YEAR FROM fecha_facturacion) = anio
    )
    SELECT mp.descripcion AS metodo_pago,
           COUNT(f.facturaid) AS cantidadmpusado,
           (COUNT(f.facturaid) * 100.0 / t.totalfacturas)::DECIMAL(5,2) AS porcentaje
    FROM facturas f
    JOIN metodos_pagos mp ON f.metodo_pagoid = mp.metodo_pagoid
    CROSS JOIN totales t
    WHERE EXTRACT(YEAR FROM f.fecha_facturacion) = anio
    GROUP BY mp.descripcion, t.totalfacturas
    ORDER BY porcentaje DESC;
$$;

