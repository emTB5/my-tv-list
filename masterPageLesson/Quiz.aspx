<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="masterPageLesson.Quiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h2>Quiz</h2>
    <div id="finalScore" runat="server"></div>
    <table border="0" width="80%">
        <tr>
            <td>
                <p>What language was Squid Game originaly in?</p>
                <br />
                <input type="radio" name="q1" value="Japanese" id="Japanese">
                <label>Japanese</label><br>
                <input type="radio" name="q1" value="Korean" id="Korean">
                <label>Korean</label><br>
                <input type="radio" name="q1" value="English" id="English">
                <label>English</label><br>
                <input type="radio" name="q1" value="German" id="German">
                <label>German</label><br>
            </td>
        </tr>
        
        <tr>
            <td>
                <p>What is the real name of the pontiac thief from Brooklyn 99?</p>
                <br />
                <input type="radio" name="q2" value="Doug Judy" id="Doug Judy">
                <label>Doug Judy</label><br>
                <input type="radio" name="q2" value="Ben Afleck" id="Ben Afleck">
                <label>Ben Afleck</label><br />
                <input type="radio" name="q2" value="Keanu Reevs" id="Keanu Reevs">
                <label>Keanu Reevs</label><br>
                <input type="radio" name="q2" value="Tohru Adachi" id="Tohru Adachi">
                <label>Tohru Adachi</label><br>
            </td>
        </tr>
        <tr>
            <td>
                <p>What item does Ms Marvel use to get her power in the show?</p>
                <br />
                <input type="radio" name="q3" value="Ring" id="Ring">
                <label>Ring</label><br>
                <input type="radio" name="q3" value="Gauntlet" id="Gauntlet">
                <label>Gauntlet</label><br>
                <input type="radio" name="q3" value="Bangle" id="Bangle">
                <label>Bangle</label><br>
                <input type="radio" name="q3" value="Sword" id="Sword">
                <label>Sword</label><br>
            </td>
        </tr>
        <tr>
            <td>
                <p>Daredevil is known as the man without?</p>
                <br />
                <input type="radio" name="q4" value="Mercy" id="Mercy">
                <label>Mercy</label><br>
                <input type="radio" name="q4" value="Sight" id="Sight">
                <label>Sight</label><br>
                <input type="radio" name="q4" value="Losses" id="Losses">
                <label>Losses</label><br>
                <input type="radio" name="q4" value="Fear" id="Fear">
                <label>Fear</label><br>
            </td>
        </tr>
        <tr>
            <td>
                <p>What song does Rick sing in order to save the earth in Rick and Morty?</p>
                <br />
                <input type="radio" name="q5" value="Dropping Schfitz" id="Dropping Schfitz">
                <label>Dropping Schfitz</label><br>
                <input type="radio" name="q5" value="Rock Hitz" id="Rock Hitz">
                <label>Rock Hitz</label><br>
                <input type="radio" name="q5" value="Get Schwifty" id="Get Schwifty">
                <label>Get Schwifty</label><br>
                <input type="radio" name="q5" value="Do the Bingortz" id="Do the Bingortz">
                <label>Do the Bingortz</label><br>
            </td>
        </tr>
        <tr>
            <td>
                <p>What does MT change her name to in Infinity Train?</p>
                <br />
                <input type="radio" name="q6" value="Kez" id="Kez">
                <label>Kez</label><br>
                <input type="radio" name="q6" value="Lake" id="Lake">
                <label>Lake</label><br>
                <input type="radio" name="q6" value="Ann" id="Ann">
                <label>Ann</label><br>
                <input type="radio" name="q6" value="Max" id="Max">
                <label>Max</label><br>
            </td>
        </tr>
        <tr>
            <td>
                <p>How many basic glyphs are there in The Owl House?</p>
                <br />
                <input type="radio" name="q7" value="four" id="four">
                <label>Four</label><br>
                <input type="radio" name="q7" value="ten" id="ten">
                <label>Ten</label><br>
                <input type="radio" name="q7" value="eight" id="eight">
                <label>Eight</label><br>
                <input type="radio" name="q7" value="three" id="three">
                <label>Three</label><br>
            </td>
        </tr>
        <tr>
            <td>
                <p>What was Watson's proffession before helping Sherlock?</p>
                <br />
                <input type="radio" name="q8" value="Doctor" id="Doctor">
                <label>Doctor</label><br>
                <input type="radio" name="q8" value="Artist" id="Artist">
                <label>Artist</label><br>
                <input type="radio" name="q8" value="Chef" id="Chef">
                <label>Chef</label><br>
                <input type="radio" name="q8" value="Hacker" id="Hacker">
                <label>Hacker</label><br>
            </td>
        </tr>
        <tr>
            <td>
                <p>What bending did Toph invent in Avatar The Last Airbender?</p>
                <br />
                <input type="radio" name="q9" value="Lava" id="Lava">
                <label>Lava</label><br>
                <input type="radio" name="q9" value="Blood" id="Blood">
                <label>Blood</label><br>
                <input type="radio" name="q9" value="Spirit" id="Spirit">
                <label>Spirit</label><br>
                <input type="radio" name="q9" value="Metal" id="Metal">
                <label>Metal</label><br>
            </td>
        </tr>
        <tr>
            <td>
                <p>Where does Beth imagine her games in Queen's Gambit?</p>
                <br />
                <input type="radio" name="q10" value="Hand" id="Hand">
                <label>On her hand</label><br>
                <input type="radio" name="q10" value="Celing" id="Celing">
                <label>On the celing</label><br>
                <input type="radio" name="q10" value="Wall" id="Wall">
                <label>On the wall</label><br>
                <input type="radio" name="q10" value="Floor" id="Floor">
                <label>On the floor</label><br>
            </td>
        </tr>
    </table>
    <br />

    <input type="submit" value="send"/>
    <input type="reset" value="delete" />

</asp:Content>
