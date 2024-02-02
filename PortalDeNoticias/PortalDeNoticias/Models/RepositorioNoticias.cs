using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
	public class RepositorioNoticias
	{
		private static List<Noticia> noticias;

		public static List<Noticia> Noticias
		{
			get
			{
				if (noticias == null)
					CriarNoticias();
				return noticias;
			}
		}

		private static void CriarNoticias()
		{
			noticias = new List<Noticia>();

			noticias.Add(new Noticia
			{
				Id = 1,
				Titulo = "Lorem ipsum dolor sit amet",
				Autor = "João Carlos",
				Data = DateTime.Today,
				Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas faucibus tortor id turpis ultrices tincidunt. Proin eu tristique enim. Donec eget convallis massa. In magna orci, hendrerit quis faucibus vitae, ultricies sed nisi. Cras ac est in massa aliquam cursus ac nec dolor. Quisque facilisis risus eu ante aliquet, a interdum leo rutrum. Vivamus pretium congue sapien sed semper. Vivamus aliquet metus quis odio dapibus, ac viverra est congue. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur tortor orci, venenatis ornare viverra eu, pulvinar ac purus. Donec elementum mattis odio vitae volutpat."
			});

			noticias.Add(new Noticia
			{
				Id = 2,
				Titulo = "Aliquam placerat interdum lectus",
				Autor = "José da Silva",
				Data = DateTime.Today.AddDays(-5),
				Conteudo = "Aliquam placerat interdum lectus, a scelerisque mauris posuere id. Mauris dui augue, blandit dignissim efficitur at, blandit in massa. Donec sed magna malesuada, aliquet ipsum quis, dignissim diam. Ut vestibulum dui eget sem lacinia, ut viverra sem venenatis. Etiam condimentum faucibus magna a aliquet. Donec vitae congue libero. Duis ut euismod leo. Proin vitae ligula augue. In quis mollis est. Morbi eget purus malesuada lectus porta maximus ac quis velit. Maecenas facilisis ligula libero, consectetur pharetra orci blandit a. Sed eget pharetra sem, a commodo ipsum. Pellentesque eu turpis augue."
			});

			noticias.Add(new Noticia
			{
				Id = 3,
				Titulo = "Pellentesque tincidunt",
				Autor = "Carla Soares",
				Data = DateTime.Today.AddDays(-10),
				Conteudo = "Pellentesque tincidunt, turpis sed vestibulum volutpat, lorem ante tempus tellus, sit amet fringilla nunc turpis vel diam. Cras interdum lacinia purus vel suscipit. Aenean a tortor dictum, interdum urna vel, porta purus. Duis posuere, eros at pretium consequat, tellus risus vulputate urna, a hendrerit metus diam lobortis tellus. Duis varius ligula a dolor dictum, vel mollis erat cursus. Donec dignissim leo sit amet porta tristique. Nunc fringilla tristique ultrices. Nunc a placerat purus, vitae accumsan odio. Donec convallis magna felis, at rhoncus mauris luctus eget. Suspendisse at tincidunt velit, in mollis nisl. Donec varius arcu a enim commodo viverra. Nam tristique nisl quis metus placerat, in euismod lectus porttitor. Curabitur commodo tortor quam. Aenean aliquet magna tellus, sit amet rhoncus odio elementum quis. Donec ut nisi nulla."
			});

			noticias.Add(new Noticia
			{
				Id = 4,
				Titulo = "Suspendisse luctus sodales ipsum",
				Autor = "Maria Cardoso",
				Data = DateTime.Today.AddDays(-10),
				Conteudo = "Suspendisse luctus sodales ipsum, ac mattis diam pretium a. Morbi vitae faucibus velit, eget gravida urna. Sed condimentum tellus molestie mauris pretium, non tempus augue condimentum. Cras imperdiet orci ut mi porta, in commodo quam lobortis. Nullam bibendum odio ante, finibus molestie felis rhoncus et. Aliquam vitae aliquet quam. Vestibulum est quam, hendrerit vel molestie at, consequat quis dui. Suspendisse augue enim, viverra nec augue eget, pretium aliquam nulla. Phasellus tristique lacus eget arcu sagittis, efficitur tempor enim fermentum. Mauris convallis enim ut hendrerit tempor. Donec quis semper ipsum."
			});

			noticias.Add(new Noticia
			{
				Id = 5,
				Titulo = "Suspendisse luctus sodales ipsum",
				Autor = "Antonio Pereira",
				Data = DateTime.Today.AddDays(-10),
				Conteudo = "Vivamus consequat libero ac condimentum semper. Integer mollis libero mi, id placerat lorem scelerisque ac. Phasellus ac posuere quam. Fusce at maximus risus, at lacinia metus. Nunc congue diam vitae massa bibendum feugiat. Donec sit amet metus risus. Suspendisse semper luctus nibh. Vivamus nec dictum magna. Etiam vitae nisl vitae nunc bibendum bibendum sed vitae mauris. Vivamus eu tincidunt diam. Suspendisse pharetra lectus ac odio suscipit, vel viverra tellus iaculis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas."
			});
		}
	}
}