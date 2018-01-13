using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Engine : MonoBehaviour {
	public Button[] botoesJogadas;
	public Text mensagem;
	public Text pontuacao;

	public GameObject adversario;

	public Sprite spritePedra;
	public Sprite spritePapel;
	public Sprite spriteTesoura;

	public string jogadaAtual;
	public bool podeJogar = true;
	private int ganhou;
	private string[] jogadasPossiveis;

	private int numVitorias;
	private int numDerrotas;


	void Start() {
		jogadasPossiveis = new string[] { "Pedra", "Papel", "Tesoura" };
	}

	public void DesabilitaBotoes(string nome) {
		foreach (Button btn in botoesJogadas) {
			Debug.Log (btn.tag + " /// " + nome);
			if (btn.tag != nome) {
				btn.gameObject.SetActive (false);
			}
		}
	}


	public void JogadaAdversario() {
		string jogada = jogadasPossiveis[Random.Range (0, 3)];
		DesabilitaBotoes (jogadaAtual);
		if (jogada == "Pedra") {
			adversario.GetComponent<SpriteRenderer> ().sprite = spritePedra;
		} else if (jogada == "Papel") {
			adversario.GetComponent<SpriteRenderer> ().sprite = spritePapel;
		} else {
			adversario.GetComponent<SpriteRenderer> ().sprite = spriteTesoura;
		}
		CalculaResultado (jogada);
		ExibeResultado ();
	}

	public void ExibeResultado() {
		if (ganhou == 0) {
			mensagem.text = "Você perdeu ... :-(";
		} else if (ganhou == 1) {
			mensagem.text = "Você ganhou! :-)";
		} else {
			mensagem.text = "Empate :-|";
		}
		pontuacao.text = numVitorias + " x " + numDerrotas;
		podeJogar = false;
	}

	public void CalculaResultado(string jogadaAdversario) {
		if (jogadaAtual == "Tesoura") {
			if (jogadaAdversario == "Pedra") {
				ganhou = 0;
				numDerrotas++;
			} else if (jogadaAdversario == "Papel") {
				ganhou = 1;
				numVitorias++;
			} else {
				ganhou = 2;
			}
		} else if (jogadaAtual == "Papel") {
			if (jogadaAdversario == "Tesoura") {
				ganhou = 0;
				numDerrotas++;
			} else if (jogadaAdversario == "Pedra") {
				ganhou = 1;
				numVitorias++;
			} else {
				ganhou = 2;
			}
		} else {
			if (jogadaAdversario == "Papel") {
				ganhou = 0;
				numDerrotas++;
			} else if (jogadaAdversario == "Tesoura") {
				ganhou = 1;
				numVitorias++;
			} else {
				ganhou = 2;
			}
		}
	}
}
