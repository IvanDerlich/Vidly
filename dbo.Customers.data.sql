SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT INTO [dbo].[Customers] ([Id], [Name], [IsSuscribedToNewsLetter], [MembershipTypeId], [BirthDate]) VALUES (2, N'Pepe Honguito', 0, 1, NULL)
INSERT INTO [dbo].[Customers] ([Id], [Name], [IsSuscribedToNewsLetter], [MembershipTypeId], [BirthDate]) VALUES (3, N'Maria Antonieta', 1, 2, NULL)
INSERT INTO [dbo].[Customers] ([Id], [Name], [IsSuscribedToNewsLetter], [MembershipTypeId], [BirthDate]) VALUES (4, N'Ricardo Papola', 0, 1, NULL)
INSERT INTO [dbo].[Customers] ([Id], [Name], [IsSuscribedToNewsLetter], [MembershipTypeId], [BirthDate]) VALUES (5, N'Figuretti', 1, 4, NULL)
SET IDENTITY_INSERT [dbo].[Customers] OFF
