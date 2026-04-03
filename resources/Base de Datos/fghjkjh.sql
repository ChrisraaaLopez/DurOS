SELECT
    t.Folio AS FolioTicket,
    t.Fecha AS FechaTicket,
    t.Mesa AS MesaTicket,
    t.Total AS TotalTicket
FROM
    Ticket t;

SELECT
    ct.fkFolio AS Folio,
    p.NombreProducto AS Producto,
    ct.Cantidad,
    ct.Preciounitario,
    ct.Subtotal
FROM
    ContenidoTicket ct
JOIN
    Productos p ON ct.Producto = p.ID;
    
    
    SELECT t.Folio AS FolioTicket, t.Fecha AS FechaTicket, t.Mesa AS MesaTicket, t.Total AS TotalTicket FROM Ticket t WHERE DATE(t.Fecha) = '2025-04-09';
    SELECT CodigoProducto AS Código, nombreProducto AS Nombre, precioPublico AS Precio, precioUnitario AS 'Precio Unitario', inventarioActual AS Inventario, inventarioMinimo AS 'Inventario Minimo' FROM productos WHERE nombreProducto LIKE '%TOS%';
    

SELECT t.Folio AS FolioTicket, t.Fecha AS FechaTicket, t.Mesa AS MesaTicket, t.Total AS TotalTicket FROM Ticket t WHERE DATE(t.Fecha) = '2025-04-09';

SELECT t.Folio AS FolioTicket, t.Fecha AS FechaTicket, t.Mesa AS MesaTicket, t.Total AS TotalTicket FROM Ticket t WHERE DATE(t.Fecha) = '{fecha.Text}';