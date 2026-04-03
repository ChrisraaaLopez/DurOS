INSERT INTO Ticket (Folio, Fecha, Mesa, Total) VALUES
('TK20250409-001', '2025-04-09 08:15:00', 1, 105.0),
('TK20250409-002', '2025-04-09 12:30:00', 3, 67.0),
('TK20250409-003', '2025-04-09 15:45:00', 2, 150.0);

INSERT INTO ContenidoTicket (fkFolio, Producto, Cantidad, Preciounitario, Subtotal) VALUES
('TK20250409-001', 1, 2, 16.0, 32.0),   -- 2 Tostadas de salsa
('TK20250409-001', 6, 1, 22.0, 22.0),   -- 1 Duro de salsa
('TK20250409-001', 29, 1, 29.0, 29.0),  -- 1 Cerveza
('TK20250409-001', 38, 4, 5.0, 20.0),   -- 4 Aguacates extra
('TK20250409-002', 11, 1, 22.0, 22.0),  -- 1 Topopo de salsa
('TK20250409-002', 30, 1, 17.0, 17.0),  -- 1 Refresco Taparoca
('TK20250409-002', 39, 2, 3.0, 6.0),    -- 2 Mayonesas extra
('TK20250409-002', 32, 1, 22.0, 22.0),  -- 1 Agua de sabor
('TK20250409-003', 8, 2, 25.0, 50.0),   -- 2 Duros con duro
('TK20250409-003', 19, 1, 30.0, 30.0),  -- 1 Chicharrón con trompa
('TK20250409-003', 28, 1, 40.0, 40.0),  -- 1 Orden de pata
('TK20250409-003', 31, 1, 22.0, 22.0);  -- 1 Refresco de vidrio


SELECT t.Folio AS FolioTicket, t.Fecha AS FechaTicket, t.Mesa AS MesaTicket, t.Total AS TotalTicket FROM Ticket t WHERE DATE(t.Fecha) = '2025-04-09';

SELECT t.Folio AS FolioTicket, t.Fecha AS FechaTicket, t.Mesa AS MesaTicket, t.Total AS TotalTicket FROM Ticket t WHERE DATE(t.Fecha) = '{fecha.Text}';


SELECT ct.fkFolio AS Folio, p.NombreProducto AS Producto, ct.Cantidad, ct.Preciounitario, ct.Subtotal FROM ContenidoTicket ct JOIN Productos p ON ct.Producto = p.ID WHERE ct.fkFolio = 'TK20250409-001';
