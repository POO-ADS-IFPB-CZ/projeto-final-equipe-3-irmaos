package view;
import javax.swing.*;


public class TelaPrincipal extends JFrame {
    private JPanel contentPane;
    private JButton buttonOK;
    private JButton buttonCancel;

    public TelaPrincipal() {
        setContentPane(contentPane);
        getRootPane().setDefaultButton(buttonOK);
    }

    public static void main(String[] args) {
        TelaPrincipal dialog = new TelaPrincipal();
        dialog.pack();
        dialog.setVisible(true);
    }
}
