package model;

import java.util.ArrayList;
import java.util.Objects;

public class Produto {


    private String codigo;
    private ArrayList<String> tipo;
    private String descricao;
    private float valorUnidade;
    private int estoque;

    public Produto(String codigo, ArrayList<String> tipo, String descricao, float valorUnidade, int estoque) {
        this.codigo = codigo;
        this.tipo = tipo;
        this.descricao = descricao;
        this.valorUnidade = valorUnidade;
        this.estoque = estoque;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public void setTipo(ArrayList<String> tipo) {
        this.tipo = tipo;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public void setValorUnidade(float valorUnidade) {
        this.valorUnidade = valorUnidade;
    }

    public void setEstoque(int estoque) {
        this.estoque = estoque;
    }

    public int getEstoque() {
        return estoque;
    }


    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Produto produto = (Produto) o;
        return Objects.equals(codigo, produto.codigo);
    }

    @Override
    public int hashCode() {
        return Objects.hashCode(codigo);
    }

    @Override
    public String toString() {
        return "Produto{" +
                "codigo='" + codigo + '\'' +
                ", tipo='" + tipo + '\'' +
                ", descricao='" + descricao + '\'' +
                ", valorUnidade=" + valorUnidade +
                ", estoque=" + estoque +
                '}';
    }
}
