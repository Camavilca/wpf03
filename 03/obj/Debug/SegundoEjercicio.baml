   M S B A M L   `   `   `  ����=  903, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_03_03  5   	       _03.SegundoEjercicio   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:_03     5   	     � Title$!  Sistema de Negocios Tecsup ��5   	   $
��1000��6-   $
��1500��6;    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Comic Sans MS)�6+   6C   �� 5       � ��$ 14(�6)   66   5      5      .��5      ��  �� Padding$ 10q�6   ._�5   
   � -   5         � RowDefinitions 5      �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��3* �6#   .+�5      � $��0��6   $��0��6     5      �� 5      $��* �6$    5      �� 5      $��* �6'   .+�5!      �� $��0��6   $��0��6*   $��10q�6:   .+�5"      �� $"��Lista de los años de pedido��6   �� 5#      -   5         ��Name$ cboAnioPedido��5#      5$      �� 5%      $"��Lista de los meses de pedido��6   �� 5&      -   5        $ cboMesPedido��5&      5'      �� 5(      $��	Empleados��6   �� 5)      -   5        $ cboEmpleado��5)      5*      �� 5+      -   5        $��Mostrar lista��5+      $
��0 15q�65   6]   5,      5-      � 5/      $��0��6   $��1��6    .+�51      �� $��10q�6   .+�53      �� $��Clientes��6   &   System.Windows.Controls.DataGrid  54      -   5        	  Name$	 dgvClientes��54   .   $��130px��6   
   AutoGenerateColumns
 .    GridLinesVisibility$ Vertical=�55   6      HeadersVisibility$	 All=�56      
�������   RowBackground
 �����   AlternatingRowBackground
 ��ح�
�������$��5q�58   .   59      �� 5;      $��	Empleados��6     5<      -   5        $	 dgvEmpleados��5<   .   $��130px��6   
 . $ Vertical=�5=   6   $	 All=�5>      
�������
 �����
 ��ح�
�������$��5q�5@   .   5A      �� 5C      $��Pedidos��6     5D      -   5        $	 
dgvDetalle��5D   .   $��130px��6   
 . $ Vertical=�5E   6   $	 All=�5F      
�������
 �����
 ��ح�
�������$��5q�5H   .   5J      �� 5L      $��Detalles del pedido��6     5M      -	   5        $	 	dgvDetall��5M   .   $��130px��6   
 . $ Vertical=�5N   6   $	 All=�5O      
�������
 �����
 ��ح�
�������$��5q�5Q   .   5S      �� 5V      $
��0 10q�6!   .+�5W      ��  �� Orientation$ 
Horizontal=�6%   .+�5X      �� $"��Cantidad total de Productos:��6$   �� 5Y      5Z      �� 5[      $ 
Horizontal=�6%   .+�5\      �� $��Monto total:��6$   �� 5]      5^      5_      5`      5a      5c      5d      5e      