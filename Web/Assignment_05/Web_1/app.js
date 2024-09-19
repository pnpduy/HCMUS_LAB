var col_1;
var col_2;
var col_3;

col_1 = prompt("Mời bạn nhập tên cột: ");
col_2 = prompt("Mời bạn nhập tên cột: ");
col_3 = prompt("Mời bạn nhập tên cột: ");



document.write("<table width='50%' border='1' cellspacing='0' cellpading='0'>");
    document.write("<td colspan='3' align='center'> Danh sách sinh viên </td>");
    document.write("<tr>");
        document.write("<td>")
            document.write(col_1);
        document.write("</td>");

        document.write("<td>")
            document.write(col_2);
        document.write("</td>");

        document.write("<td>")
            document.write(col_3);
        document.write("</td>");
    document.write("</tr>")

    document.write("<tr>");
        document.write("<td>")
        document.write("</td>");

        document.write("<td>")
        document.write("</td>");

        document.write("<td>")
        document.write("</td>");
    document.write("</tr>")
    
document.write("</table>");