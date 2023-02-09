<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CambioPassword.aspx.cs" Inherits="Forms_CambioPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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

                                <!-- Nuova password input -->
                                <div class="form-outline mb-3">
                                    <h3>
                                        <label class="form-label" for="form3Example4">Inserisci la tua nuova password</label></h3>
                                    <asp:TextBox ID="txtNuovaPWD" runat="server" class="form-control form-control-lg"
                                        placeholder="Inserisci qui la tua nuova password" TextMode="Password"></asp:TextBox>
                                    <div class="d-flex justify-content-between align-items-center">
                                        <!-- Checkbox -->
                                        <div class="form-check mb-0">
                                            <label class="form-check-label" for="form4Example5">
                                                Mostra password
                                            </label>
                                            <input class="form-check-input me-2" type="checkbox" onclick="myFunction()" value="" id="form4Example5" />
                                        </div>
                                    </div>
                                </div>

                                <!-- Conferma password input -->
                                <div class="form-outline mb-3">
                                    <h3>
                                        <label class="form-label" for="form3Example4">Conferma la tua nuova password</label></h3>
                                    <asp:TextBox ID="txtConfermaPWD" runat="server" class="form-control form-control-lg"
                                        placeholder="Conferma qui la tua nuova password" TextMode="Password"></asp:TextBox>
                                    <div class="d-flex justify-content-between align-items-center">
                                        <!-- Checkbox -->
                                        <div class="form-check mb-0">
                                            <label class="form-check-label" for="form4Example4">
                                                Mostra password
                                            </label>
                                            <input class="form-check-input me-2" type="checkbox" onclick="myFunction2()" value="" id="form4Example4" />
                                        </div>
                                    </div>
                                </div>

                                <div class="text-center text-lg-start mt-4 pt-2">                                  
                                    <center>
                                        <asp:Button ID="btnAccedi" runat="server" Text="Aggiorna Password" class="btn btn-primary btn-lg" Style="width: 40%" OnClick="btnAccedi_Click" /></center>
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
            var x = document.getElementById("txtNuovaPWD");
            if (x.type === "password") {
                x.type = "text";
            } else {
                x.type = "password";
            }

        }
        function myFunction2() {
            var x = document.getElementById("txtConfermaPWD");
            if (x.type === "password") {
                x.type = "text";
            } else {
                x.type = "password";
            }
        }
    </script>
</body>
</html>
