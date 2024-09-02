import javax.swing.*;

public class TelaPrincipal extends JDialog {
    private JPanel contentPane;
    private JButton buttonOK;
    private JButton buttonCancel;

    public TelaPrincipal() {
        setContentPane(contentPane);
        setModal(true);
        getRootPane().setDefaultButton(buttonOK);
    }

    public static void main(String[] args) {
        TelaPrincipal dialog = new TelaPrincipal();
        dialog.pack();
        dialog.setVisible(true);
        System.exit(0);
    }
}
