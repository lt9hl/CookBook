   M S B A M L   `   `   `  ����F  BCookingBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CookingBook.PagesCookingBook.Pages  5      "    CookingBook.Pages.PageRecipe   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:CookingBook.Pages     5        N� Title$  
PageRecipe��5	      .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $��33 �6   �� 5      $	��497 �6   �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$ listProducts��5      $��1��6)   $��0,52,0,0q�66   ��5      �� 5      .R�5      �  5      �� 5      $	��100 �6/   �� 5      $	��400 �6/   �� 5      $	��200 �6/   .+�5      �� $��0��6@   ��6    �� *CurrentPhoto+6@   �� 5      $��1��6%   $
��auto��65    �� Orientation$ Vertical=�6B   $
��Left=�6Y   .+�5      �� $
��auto��6(   $
��Wrap=�65   $
��auto��6I   �� 5    "   $�Название: ��6&    �� 5!   "   �6&   �� *
RecipeName+5"      �� 5#      $
��auto��6(   $
��Wrap=�65   $
��auto��6I   �� 5$   &   $�Категория: ��6*    �� 5%   &   �6*   �� *Categories.CategoryName+5&      �� 5'      $
��auto��6(   $
��Wrap=�65   $
��auto��6I   �� 5(   *   $�Описание: ��6.    �� 5)   *   �6.   �� *Description+5*      5+      �� 5,      $��2��6%   $
��auto��65   $ Vertical=�6B   $
��Left=�6Y   .+�5-      �� $
��auto��6(   $
��Wrap=�65   $
��auto��6I   �� 5.   "   $�Время: ��6&    �� 5/   "   �6&   �� *CookingTime+ �� 50   "   $�мин��6&   51      52      53      54      56      �� 57   
   -   5         ��Name$ ComboFilter��57      $
��Left=�6(   $��	30,10,0,0q�6C   $	��Top=�6V   $	��209��6n   6z   �� 58   
   -   5        $ 	ComboSort��58      $
��Left=�6&   $��
253,10,0,0q�6A   $	��Top=�6U   $	��209��6m   6y   �� 59   
   -   5         ��Name$ 	tbCounter��59      $��Не найдено��6'   $��2��69   $	��167��6F   $
��Left=�6R   �� 5:   
   -   5         ��Name$ 
TextSearch��5:      $
��Left=�6&   $��
565,10,0,1q�6A   $	��209��6U   $��21.96��6a   6p   5;      5<      