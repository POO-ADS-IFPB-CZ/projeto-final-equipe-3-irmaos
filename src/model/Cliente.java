package model;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Objects;

public class Cliente {

    private String nome;
    private String cpf;
    private String telefone;
    private String endereco;
    private LocalDate dataCadastro;
    private ArrayList<Cliente> historicoCompras;

    public Cliente(String nome, LocalDate dataCadastro, String endereco, String telefone, String cpf) {
        this.nome = nome;
        this.dataCadastro = dataCadastro;
        this.endereco = endereco;
        this.telefone = telefone;
        this.cpf = cpf;
        this.historicoCompras = new ArrayList<>();
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public String getTelefone() {
        return telefone;
    }

    public void setTelefone(String telefone) {
        this.telefone = telefone;
    }

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

    public void setDataCadastro(LocalDate dataCadastro) {
        this.dataCadastro = dataCadastro;
    }

    public void setHistoricoCompras(ArrayList<Cliente> historicoCompras) {
        this.historicoCompras = historicoCompras;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Cliente cliente = (Cliente) o;
        return Objects.equals(cpf, cliente.cpf);
    }

    @Override
    public int hashCode() {
        return Objects.hashCode(cpf);
    }

    @Override
    public String toString() {
        return "Cliente{" +
                "nome='" + nome + '\'' +
                ", cpf='" + cpf + '\'' +
                ", telefone='" + telefone + '\'' +
                ", endereco='" + endereco + '\'' +
                ", dataCadastro=" + dataCadastro +
                ", historicoCompras=" + historicoCompras +
                '}';
    }
}