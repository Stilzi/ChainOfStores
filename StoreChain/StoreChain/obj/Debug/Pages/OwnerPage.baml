   M S B A M L   `   `   `  ����E  AStoreChain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StoreChain.PagesStoreChain.Pages  5           StoreChain.Pages.OwnerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:StoreChain.Pages     5      -   5          N� Title$  	OwnerPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.5* �6   6,   �� 5      $��2* �6   6*   �� 5      $
��0.5* �6   6,   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ownerdg��5      $��1��5         AutoGenerateColumns .     
IsReadOnly .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *ID+  5      $ ФИО��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.5* 5   %    5   %   �� *Name+  5      $ Телефон��6%   $
 0.5* 5   %    5   %   �� *Phone+5      �� 5    
   -   5        	 ��Name$	 	insertbtn��5       $��Добавить��5!      $	��200��5"      $��30��5#      $��2��5$      $��Center=�5%      61   �� 5&   
   -   5        $	 backbtn��5&      $��
Назад��5'      $	��200��5(      $��30��5)      $��0��5*      $
��Left=�5+      $��20q�5,      6    �� 5-   
   -   5        $	 	updatebtn��5-      $��2��5.      $	��200��5/      $��30��50      $ ��Редактировать��51      $
��Left=�52      $��20q�53      6    �� 54   
   -   5        $	 	deletebtn��54      $��Удалить��55      $��30��56      $	��200��57      $��Right=�58      $��20q�59      $��2��5:      6!   �� 5;   
   $��Поиск:��6   $��20(�5<      $��Center=�5=      $��Center=�5>      $��	30 15 0 0q�5?      �� 5@   
   -   5        
 ��Name$
 search��5@      $��40��5A      $	��300��5B      $��Right=�5C      $��20q�5D      6    5E      5F      