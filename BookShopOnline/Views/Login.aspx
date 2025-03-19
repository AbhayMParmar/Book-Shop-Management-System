<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookShopOnline.Views.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Login</title>
  <link rel="stylesheet"  href="../Assets1/lib/css/bootstrap.min.css"/>
<style>
    #Logo{
        height:30%;
        width:30%;
    }
</style>
</head>
<body>
   <div class="container-fluid">
       <div class="row mt-5 mb-5">

       </div>
       <div class="row">
           <div class="col-md-4">

           </div>
           <div class="col-md-4">
              <form id="form1" runat="server">
               <div>
                  <div class="row">
                      <div class="col-md-12">
                          <center>
                                <h4  style="color:teal">Book Shop Management System</h4>
                                <img id="Logo" src="../Assets1/Img/Logo.png" />
                          </center> 
                     </div>
                  </div>
               </div>
                  <br /><br />
                  <br />
                  <br />
                   <div class="mt-3">
                       <label for="" class="form-label">User Name</label>
                       <input type="email" placeholder="Your Email Here" autocomplete="off" runat="server" class="form-control" id="UnameTb" />
                   </div>
                   <div class="mt-3">
                       <label for="" class="form-label">Password</label>
                       <input type="password" placeholder="Password" autocomplete="off" runat="server" class="form-control" id="PassTb" />
                   </div>
                   <div class="mt-3 d-grid">
                       <asp:Label runat="server" id="ErrMsg" class="text-danger text-center"></asp:Label> <br />
                      <asp:Button Text="Login" runat="server" class="btn-success btn" ID="LoginBtn" Width="402px" OnClick="LoginBtn_Click" />
                  </div>
              </form>
             </div>
           <div class="col-md-4">

           </div>
       </div>
</div>
</body>
</html>

