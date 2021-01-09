<%@ Page Title="" Language="C#" MasterPageFile="~/Masterstr.Master" AutoEventWireup="true" CodeBehind="Naslovna.aspx.cs" Inherits="ProjektRWA.WebForm2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="content1placeholder" runat="server">

    <div class="izdv_text" id="izdv">Izdvojeno</div>
        <br />
        <br />
        <br />
        <br />
    <div id="izdvokvir" class="okvir">
        <!-- okvir pa unutar toga cu dodat 1 primjera radi manualno proizvod
            kasnije cu napravit da uzima iz database i od tih podataka radi x kartica 
            to sve preko codebacka-->
        <div class="kartica" id="primjer">
            <img class="kartica_img" src="test.jpg"/>
            <a class="kartica_txt">placeholder</a>
        </div>
    </div>
     
    <br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>

    <div class="izdv_text" id="izdv2">nes drugo</div>
    <br/><br/><br/><br/>

    <div id="izdvokvir2" class="okvir">
        <div class="kartica" id="primjer2">
            <img class="kartica_img" src="test.jpg"/>
            <a class="kartica_txt">placeholder</a>
        </div>
    </div>
</asp:Content>
