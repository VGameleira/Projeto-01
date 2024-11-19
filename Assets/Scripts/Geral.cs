using UnityEngine;
using UnityEngine.UI;

public class Geral : MonoBehaviour
{
    internal int placarJogadorNum, recordNum;
    public Text placarJogadorTexto, recordTexto;
    public GameObject gameOver, personagemPrincipal, ferramenta;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placarJogadorNum = 0;
        recordNum = 0;
    }


        public void MarcarPonto()
    {
        placarJogadorNum += 1;
        
        if (recordNum < placarJogadorNum) 
            recordNum += 1;

        AtualizarTextoPlacar();
        
        GetComponent<AudioSource>().Play(); 
    }

        public void AtualizarTextoPlacar()
    {
        placarJogadorTexto.text = "Itens coletados:" + placarJogadorNum;
        recordTexto.text = "Recorde Atual:" + recordNum;
    }


    public void IniciarPartida()
    {
        placarJogadorNum = 0;
        AtualizarTextoPlacar();

        
        

        //Sumir Gamer-Over
        gameOver.SetActive(false);

        //Reposicionar a Luva
        personagemPrincipal.transform.position = new Vector3(875, 250, 0);

        //Reposicionar Ferramenta
        ferramenta.GetComponent<ControladorFerramenta>().posicaoFerramenta = new Vector3();

        //Voltar a Velocidade para o "padrão"
        ferramenta.GetComponent<ControladorFerramenta>().deslocamentoFerramenta = 
        ferramenta.GetComponent<ControladorFerramenta>().deslocamentoInicial;

    }

}   