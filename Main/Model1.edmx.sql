
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/31/2017 18:50:26
-- Generated from EDMX file: D:\Taller\Taller\Main\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Taller];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ProductoSet'
CREATE TABLE [dbo].[ProductoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Precio] float  NOT NULL,
    [ModeloAuto] nvarchar(max)  NOT NULL,
    [Estado] int  NOT NULL,
    [StockMinimo] nvarchar(max)  NOT NULL,
    [Creado] datetime  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Stock] int  NOT NULL,
    [Categoria_Id] int  NOT NULL
);
GO

-- Creating table 'CategoriaSet'
CREATE TABLE [dbo].[CategoriaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Estado] int  NOT NULL,
    [Creado] datetime  NOT NULL
);
GO

-- Creating table 'HistorialSet'
CREATE TABLE [dbo].[HistorialSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Creado] datetime  NOT NULL,
    [Estado] int  NOT NULL,
    [Total] float  NOT NULL,
    [Deuda] float  NOT NULL,
    [Patente] nvarchar(max)  NOT NULL,
    [Cliente_Id] int  NOT NULL
);
GO

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Estado] int  NOT NULL,
    [Creado] datetime  NOT NULL
);
GO

-- Creating table 'PermisoSet'
CREATE TABLE [dbo].[PermisoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolSet'
CREATE TABLE [dbo].[RolSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [User] nvarchar(max)  NOT NULL,
    [Pass] nvarchar(max)  NOT NULL,
    [Rol_Id] int  NOT NULL
);
GO

-- Creating table 'HistorialProducto'
CREATE TABLE [dbo].[HistorialProducto] (
    [Historial_Id] int  NOT NULL,
    [Producto_Id] int  NOT NULL
);
GO

-- Creating table 'RolPermiso'
CREATE TABLE [dbo].[RolPermiso] (
    [Rol_Id] int  NOT NULL,
    [Permiso_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ProductoSet'
ALTER TABLE [dbo].[ProductoSet]
ADD CONSTRAINT [PK_ProductoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategoriaSet'
ALTER TABLE [dbo].[CategoriaSet]
ADD CONSTRAINT [PK_CategoriaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HistorialSet'
ALTER TABLE [dbo].[HistorialSet]
ADD CONSTRAINT [PK_HistorialSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PermisoSet'
ALTER TABLE [dbo].[PermisoSet]
ADD CONSTRAINT [PK_PermisoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RolSet'
ALTER TABLE [dbo].[RolSet]
ADD CONSTRAINT [PK_RolSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Historial_Id], [Producto_Id] in table 'HistorialProducto'
ALTER TABLE [dbo].[HistorialProducto]
ADD CONSTRAINT [PK_HistorialProducto]
    PRIMARY KEY CLUSTERED ([Historial_Id], [Producto_Id] ASC);
GO

-- Creating primary key on [Rol_Id], [Permiso_Id] in table 'RolPermiso'
ALTER TABLE [dbo].[RolPermiso]
ADD CONSTRAINT [PK_RolPermiso]
    PRIMARY KEY CLUSTERED ([Rol_Id], [Permiso_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Categoria_Id] in table 'ProductoSet'
ALTER TABLE [dbo].[ProductoSet]
ADD CONSTRAINT [FK_ProductoCategoria]
    FOREIGN KEY ([Categoria_Id])
    REFERENCES [dbo].[CategoriaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoCategoria'
CREATE INDEX [IX_FK_ProductoCategoria]
ON [dbo].[ProductoSet]
    ([Categoria_Id]);
GO

-- Creating foreign key on [Historial_Id] in table 'HistorialProducto'
ALTER TABLE [dbo].[HistorialProducto]
ADD CONSTRAINT [FK_HistorialProducto_Historial]
    FOREIGN KEY ([Historial_Id])
    REFERENCES [dbo].[HistorialSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Producto_Id] in table 'HistorialProducto'
ALTER TABLE [dbo].[HistorialProducto]
ADD CONSTRAINT [FK_HistorialProducto_Producto]
    FOREIGN KEY ([Producto_Id])
    REFERENCES [dbo].[ProductoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HistorialProducto_Producto'
CREATE INDEX [IX_FK_HistorialProducto_Producto]
ON [dbo].[HistorialProducto]
    ([Producto_Id]);
GO

-- Creating foreign key on [Cliente_Id] in table 'HistorialSet'
ALTER TABLE [dbo].[HistorialSet]
ADD CONSTRAINT [FK_HistorialCliente]
    FOREIGN KEY ([Cliente_Id])
    REFERENCES [dbo].[ClienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HistorialCliente'
CREATE INDEX [IX_FK_HistorialCliente]
ON [dbo].[HistorialSet]
    ([Cliente_Id]);
GO

-- Creating foreign key on [Rol_Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [FK_RolUsuario]
    FOREIGN KEY ([Rol_Id])
    REFERENCES [dbo].[RolSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolUsuario'
CREATE INDEX [IX_FK_RolUsuario]
ON [dbo].[UsuarioSet]
    ([Rol_Id]);
GO

-- Creating foreign key on [Rol_Id] in table 'RolPermiso'
ALTER TABLE [dbo].[RolPermiso]
ADD CONSTRAINT [FK_RolPermiso_Rol]
    FOREIGN KEY ([Rol_Id])
    REFERENCES [dbo].[RolSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Permiso_Id] in table 'RolPermiso'
ALTER TABLE [dbo].[RolPermiso]
ADD CONSTRAINT [FK_RolPermiso_Permiso]
    FOREIGN KEY ([Permiso_Id])
    REFERENCES [dbo].[PermisoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolPermiso_Permiso'
CREATE INDEX [IX_FK_RolPermiso_Permiso]
ON [dbo].[RolPermiso]
    ([Permiso_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------