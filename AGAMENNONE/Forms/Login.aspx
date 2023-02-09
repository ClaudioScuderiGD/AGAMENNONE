<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Forms_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link href="assets/css/style.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
</head>
<body>
    <center>
        <form id="form1" runat="server">
            <div>
                <section class="vh-100">
                    <div class="container-fluid h-custom">
                        <div class="row d-flex justify-content-center align-items-center h-100" style="margin-top: 300px">
                            <div class="col-md-9 col-lg-6 col-xl-5">
                                <img src="/assets/images/fotoSito.jpg"
                                    class="img-fluid" alt="Sample image" />
                            </div>
                            <div class="col-md-8 col-lg-6 col-xl-4 offset-xl-1">

                                <!-- Email input -->
                                <div class="form-outline mb-4">
                                    <label class="form-label" for="form3Example3">Inserisci la tua e-email</label>
                                    <%--<input type="email" id="form3Example3" class="form-control form-control-lg"
                                        placeholder="Enter a valid email address" />--%>
                                    <asp:TextBox ID="txtEmail" runat="server" class="form-control form-control-lg"
                                        placeholder="Inserisci un indirizzo e-mail valido"></asp:TextBox>                                
                                </div>

                                <!-- Password input -->
                                <div class="form-outline mb-3">
                                    <label class="form-label" for="form3Example4">Inserisci la tua password</label>
                                    <%--<input type="password" id="form3Example4" class="form-control form-control-lg"
                                        placeholder="Enter password" />--%>
                                    <asp:TextBox ID="txtPWD" runat="server" class="form-control form-control-lg"
                                        placeholder="Inserisci una password valida" TextMode="Password"></asp:TextBox>                                   
                                </div>

                                <div class="d-flex justify-content-between align-items-center">
                                    <!-- Checkbox -->
                                    <div class="form-check mb-0">
                                        <label class="form-check-label" for="form2Example3">
                                            Mostra password
                                        </label>
                                        <input class="form-check-input me-2" type="checkbox" onclick="myFunction()" value="" id="form2Example3" />
                                                                            
                                    </div>
                                    <a href="#!" class="text-body">Non sei ancora registrato?</a>
                                </div>

                                <div class="text-center text-lg-start mt-4 pt-2">
                                    <%--<button type="button" class="btn btn-primary btn-lg"
                                        style="padding-left: 2.5rem; padding-right: 2.5rem;">
                                        Login</button>--%>
                                    <center><asp:Button ID="btnAccedi" runat="server" Text="Accedi" class="btn btn-primary btn-lg" style="width:40%"/></center>
                                </div>
                            </div>
                        </div>
                    </div>

                </section>
            </div>
        </form>
    </center>
    <script>
        function myFunction() {
            var x = document.getElementById("txtPWD");
            if (x.type === "password") {
                x.type = "text";
            } else {
                x.type = "password";
            }
        }
    </script>
</body>
</html>
