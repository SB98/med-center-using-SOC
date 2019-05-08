<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manager.aspx.cs" Inherits="WCFManagerModule.Manager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <asp:GridView ID="GridView1"  AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="ProductId" 
            runat="server" ShowHeaderWhenEmpty="true" BackColor="White" 
           OnRowCommand="GridView1_RowCommand" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit"
            OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting" 
            BorderColor ="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />


            <Columns>
                <asp:TemplateField HeaderText="Product Id"> 
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("ProductId") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox runat="server" ID="txtprodid" Text='<%# Eval("ProductId") %>' > </asp:TextBox>

                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox runat="server" ID="txtprodidFooter" > </asp:TextBox>
                        
                    </FooterTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Product Name"> 
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("ProductName") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox runat="server" ID="txtprodname" Text='<%# Eval("ProductName") %>' > </asp:TextBox>

                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox runat="server" ID="txtprodnameFooter" > </asp:TextBox>
                        
                    </FooterTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Product Price"> 
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("ProductPrice") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox runat="server" ID="txtprodprice" Text='<%# Eval("ProductPrice") %>' > </asp:TextBox>

                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox runat="server" ID="txtprodpriceFooter" > </asp:TextBox>
                        
                    </FooterTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Category"> 
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("Category") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox runat="server" ID="txtCategory" Text='<%# Eval("Category") %>' > </asp:TextBox>

                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox runat="server" ID="txtCategoryFooter" > </asp:TextBox>
                        
                    </FooterTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Quantity"> 
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("Quantity") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox runat="server" ID="txtquantity" Text='<%# Eval("Quantity") %>' > </asp:TextBox>

                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox runat="server" ID="txtquantityFooter" > </asp:TextBox>
                        
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ImageUrl="~/Images/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                        <asp:ImageButton ImageUrl="~/Images/delete.png" runat="server" CommandName="Delete" ToolTip="Delete" Width="20px" Height="20px"/>
                    </ItemTemplate>
                    <EditItemTemplate>
                          <asp:ImageButton ImageUrl="~/Images/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px"/>
                        <asp:ImageButton ImageUrl="~/Images/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px"/>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:ImageButton ImageUrl="~/Images/Addnew.png" runat="server" CommandName="Addnew" ToolTip="Addnew" Width="20px" Height="20px"/>
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green"></asp:Label>
        <br />
         <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red"></asp:Label>
        
        <br />
    
    </div>
    </form>
</body>
</html>
