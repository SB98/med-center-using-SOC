<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WCFManagerModule.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
	<link rel="stylesheet" type="text/css" href="css/style.css"/>
</head>
<body id="signup">
    <form id="form1" runat="server">
   	<header>
		<div class="header_top">
			<div class="container">
				<div class="row">
					<div class="col-4">
						<div class="logo">
							<a href="index.html"><img src="img/logo1.png" class="img-responsive" /></a>
						</div>
					</div>
					<div class="col-8">
						<a href="Login.aspx" class="btn btn-info btn1"> Sign In</a>
					</div>
				</div>
			</div>
		</div>
		
		
	</header>
	<main>
		<section id="loginform">
			<div class="container">
				<div class="row">
					<div class="col-3">
						
					</div>
					<div class="col-6">
						
						<%--<form>--%>
							<div class="form">
								<h2 class="text-center">Sign Up</h2>
								<div class="form-group">
									<label  class="control-label col">Username:</label>
									<div class="col-12">
										<asp:TextBox ID="txtusername" runat="server" class="form-control" type="text" name="uname"/>
									</div>
								</div>
								<div class="form-group">
									<label  class="control-label col">Email:</label>
									<div class="col-12">
										<asp:TextBox ID="txtemail" runat="server" class="form-control" type="email" name="mail"/>
									</div>
								</div>
								<div class="form-group">
									<label  class="control-label col">Password:</label>
									<div class="col-12">
										<asp:TextBox ID="txtpass" runat="server" class="form-control" type="password" name="pass"/>
									</div>
								</div>
								<div class="form-group">
									<label  class="control-label col">Conform Password:</label>
									<div class="col-12">
										<asp:TextBox ID="txtconfirmpass" runat="server" class="form-control" type="password" name="cpass"/>
									</div>
								</div>

                                <div class="form-group">
									<label  class="control-label col">Address:</label>
									<div class="col-12">
										<asp:TextBox ID="txtaddress" runat="server" class="form-control" type="text" name="address"/>
									</div>
								</div>
                                <div class="form-group">
									<label  class="control-label col">PhoneNumber:</label>
									<div class="col-12">
										<asp:TextBox ID="txtphonenumber" runat="server" class="form-control" type="number" name="phonenumber"/>
									</div>
								</div>


								<div class="form-group text-right">
									<div class="col">
										<asp:Button ID="btnsignup" Text="Sign Up" runat="server" class="btn frm-btn" OnClick="btnsignup_Click" ></asp:Button>
									</div>
								</div>
							</div>
						<%--</form>--%>
					</div>
					<div class="col-3">
					</div>
				</div>
			</div>
		</section>
	</main>
	<footer>
		<div class="container">
			<div class="row">
				<div class="col text-center">
					<p>&copy; Copyrights are Reserved 2018-19</p>
				</div>
			</div>
		</div>
	</footer>
    </form>
</body>
</html>
