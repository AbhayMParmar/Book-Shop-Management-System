<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Adminmaster.Master" AutoEventWireup="true" CodeBehind="Seller.aspx.cs" Inherits="BookShopOnline.Views.Admin.Seller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
    <div class="row">
        <div class="col">
           <h3 class="text-center">Manage Sellers</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                 <label for="" class="form-label text-success">Seller Name </label>
                 <input type="text" placeholder="Name" runat="server" id="SNameTb" autocomplete="off" class="form-control" />
            </div>
            <div class="mb-3">
                 <label for="" class="form-label text-success">Seller Email </label>
                 <input type="Email" placeholder="Seller Email" runat="server" id="EmailTb" autocomplete="off" class="form-control" />
            </div>
            <div class="mb-3">
                 <label for="" class="form-label text-success">Seller Phone </label>
                 <input type="Text" placeholder="Phone Number" runat="server" id="PhoneTb" autocomplete="off" class="form-control" />
            </div>
            <div class="mb-3">
                 <label for="" class="form-label text-success">Seller Address </label>
                 <input type="text" placeholder="Password" runat="server" id="AddressTb" autocomplete="off" class="form-control" />
            </div>
            
            <div class="row">
                 <asp:Label runat="server" id="ErrMsg" class="text-danger text-center"></asp:Label>
                <div class="col d-grid"><asp:Button Text="Upadte" runat="server" ID="Editbtn" class="btn-warning btn-block btn" OnClick="Editbtn_Click" /></div>
                <div class="col d-grid"><asp:Button Text="Save" runat="server" ID="Savebtn" class="btn-success btn-block btn" OnClick="Savebtn_Click" /></div>
                <div class="col d-grid"><asp:Button Text="Delete" runat="server" ID="Deletebtn" class="btn-danger btn-block btn" OnClick="Deletebtn_Click" /></div>

            </div>
        </div>
             <div class="col-md-8">
                 <asp:GridView ID="SellerList" runat="server"   CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" Width="600px" OnSelectedIndexChanged="SellerList_SelectedIndexChanged1">
                      <AlternatingRowStyle BackColor="White" />
                      <EditRowStyle BackColor="#7C6F57" />
                      <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                      <HeaderStyle BackColor="teal" Font-Bold="false" ForeColor="White" />
                      <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                      <RowStyle BackColor="#E3EAEB" />
                      <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                      <SortedAscendingCellStyle BackColor="#F8FAFA" />
                      <SortedAscendingHeaderStyle BackColor="#246B61" />
                      <SortedDescendingCellStyle BackColor="#D4DFE1" />
                      <SortedDescendingHeaderStyle BackColor="#15524A" />
                 </asp:GridView>
             </div>
    </div>
</div>
</asp:Content>
