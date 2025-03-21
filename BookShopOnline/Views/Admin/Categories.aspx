﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Adminmaster.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="BookShopOnline.Views.Admin.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
    <div class="row">
        <div class="col">
           <h3 class="text-center">Manage Categories</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                 <label for="" class="form-label text-success">Categories Name</label>
                 <input type="text" placeholder="Categories Name" autocomplete="off" class="form-control" runat="server" id="CatNameTb" />
            </div>
            <div class="mb-3">
                 <label for="" class="form-label text-success">Categories Discription </label>
                 <input type="text" placeholder="Discription" autocomplete="off" class="form-control" runat="server" id="DescriptionTb"/>
            </div>
          
            <div class="row">
                <asp:Label runat="server" id="ErrMsg" class="text-danger text-center"></asp:Label>
                <div class="col d-grid"><asp:Button Text="Upadte" runat="server" id="Editbtn" class="btn-warning btn-block btn" OnClick="Editbtn_Click" /></div>
                <div class="col d-grid"><asp:Button Text="Save" runat="server" id="savebtn" class="btn-success btn-block btn" OnClick="savebtn_Click" /></div>
                <div class="col d-grid"><asp:Button Text="Delete" runat="server" id="deletebtn" class="btn-danger btn-block btn" OnClick="deletebtn_Click" /></div>

            </div>
        </div>
        <div class="col-md-8">
            <asp:GridView ID="CategoriesList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" Width="600px" OnSelectedIndexChanged="AuthorsList_SelectedIndexChanged1">
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
