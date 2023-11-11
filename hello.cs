using System;
using System.Windows.Forms;
using System.Drawing;

public class GameForm : Form
{
    private Button[,] buttons;
    private char currentPlayer;

    public GameForm()
    {
        currentPlayer = 'X';
        buttons = new Button[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                buttons[i, j] = new Button();
                buttons[i, j].Location = new Point(i * 100, j * 100);
                buttons[i, j].Size = new Size(100, 100);
                buttons[i, j].Click += Button_Click;
                Controls.Add(buttons[i, j]);
            }
        }
    }

    private void Button_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        if (button.Text == "")
        {
            button.Text = currentPlayer.ToString();
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
    }
    public static void Main()
{
    Application.Run(new GameForm());
}

}

