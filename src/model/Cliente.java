package model;

import java.io.Serializable;
import java.time.LocalDate;
import java.util.ArrayList;

public class Cliente extends Pessoa implements Serializable{

    private LocalDate dataCadastro;
    private ArrayList<String> historicoCompras;

    public Cliente(String nome, String cpf, String endereco, String telefone, LocalDate dataCadastro, ArrayList<String> historicoCompras) {
        super(nome, cpf, endereco, telefone);
        this.dataCadastro = dataCadastro;
        this.historicoCompras = historicoCompras;
    }

    public LocalDate getDataCadastro() {
        return dataCadastro;
    }

    public void setDataCadastro(LocalDate dataCadastro) {
        this.dataCadastro = dataCadastro;
    }

    public ArrayList<String> getHistoricoCompras() {
        return historicoCompras;
    }

    public void setHistoricoCompras(ArrayList<String> historicoCompras) {
        this.historicoCompras = historicoCompras;
    }


}
