using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Metro_Navigation
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>

	public class Station
	{
		public int		branch = 0;
		public Ellipse	obj = null;
		public Station	next = null;
		public Station	prev = null;
		public Station	transfer = null;
		public int		id;
		public int		selected = 0;

		public Station()
		{

		}
		public Station(int Branch, Ellipse Obj, int ID)
		{
			branch = Branch;
			obj = Obj;
			id = ID;
		}

	}

	public partial class MainWindow : Window
	{
		public int			step_delay = 700;
		public int			st_sl = 0;
		public int			fn_sl = 0;
		public Station[]	Station_db = new Station[54];

		public MainWindow()
		{
			InitializeComponent();
			mth_create_stations_arr();
		}

		public Station			mth_select_connections(Station st, Station next, Station prev, Station transfer)
		{
			st.next = next;
			st.prev = prev;
			st.transfer = transfer;
			return (st);
		}

		public void		mth_create_stations_arr()
		{
			#region Green_Branch_Stations_Selections
			Station st_Syrets = new Station(1, Syrets, 0);
			Station st_Dorohozhchi = new Station(1, Dorohozhchi, 1);
			Station st_Lukianivska = new Station(1, Lukianivska, 2);
			Station st_Lvivska_Brama = new Station(1, Lvivska_Brama, 3);
			Station st_Zoloti_Vorota = new Station(1, Zoloti_Vorota, 4);
			Station st_Palats_sportu = new Station(1, Palats_sportu, 5);
			Station st_Klovska = new Station(1, Klovska, 6);
			Station st_Pecherska = new Station(1, Pecherska, 7);
			Station st_Druzhby_Narodiv = new Station(1, Druzhby_Narodiv, 8);
			Station st_Vydubychi = new Station(1, Vydubychi, 9);
			Station st_Telychka = new Station(1, Telychka, 10);
			Station st_Slavutych = new Station(1, Slavutych, 11);
			Station st_Osokorky = new Station(1, Osokorky, 12);
			Station st_Pozniaky = new Station(1, Pozniaky, 13);
			Station st_Kharkivska = new Station(1, Kharkivska, 14);
			Station st_Vyrlytsia = new Station(1, Vyrlytsia, 15);
			Station st_Boryspilska = new Station(1, Boryspilska, 16);
			Station st_Chervony_Khutir = new Station(1, Chervony_Khutir, 17);
			#endregion
			#region Red_Branch_Stations_Selections
			Station st_Akademmistechko = new Station(2, Akademmistechko, 0);
			Station st_Zhytomyrska = new Station(2, Zhytomyrska, 1);
			Station st_Sviatoshyn = new Station(2, Sviatoshyn, 2);
			Station st_Nyvky = new Station(2, Nyvky, 3);
			Station st_Beresteiska = new Station(2, Beresteiska, 4);
			Station st_Shuliavska = new Station(2, Shuliavska, 5);
			Station st_Politkhnichnyi_Instytut = new Station(2, Politkhnichnyi_Instytut, 6);
			Station st_Vokzalna = new Station(2, Vokzalna, 7);
			Station st_Universytet = new Station(2, Universytet, 8);
			Station st_Teatralna = new Station(2, Teatralna, 9);
			Station st_Khreshatyk = new Station(2, Khreshatyk, 10);
			Station st_Arsenalna = new Station(2, Arsenalna, 11);
			Station st_Dnipro = new Station(2, Dnipro, 12);
			Station st_Hidropark = new Station(2, Hidropark, 13);
			Station st_Livoberezhna = new Station(2, Livoberezhna, 14);
			Station st_Darnitsia = new Station(2, Darnitsia, 15);
			Station st_Chernihivska = new Station(2, Chernihivska, 16);
			Station st_Lisova = new Station(2, Lisova, 17);
			#endregion
			#region Blue_Branch_Stations_Selections
			Station st_Heroiv_Dnipra = new Station(3, Heroiv_Dnipra, 0);
			Station st_Minska = new Station(3, Minska, 1);
			Station st_Obolon = new Station(3, Obolon, 2);
			Station st_Petrivka = new Station(3, Petrivka, 3);
			Station st_Tarasa_Shevchenka = new Station(3, Tarasa_Shevchenka, 4);
			Station st_Kontraktova_Ploshcha = new Station(3, Kontraktova_Ploshcha, 5);
			Station st_Poshtova_Ploshcha = new Station(3, Poshtova_Ploshcha, 6);
			Station st_Maidan_Nezalezhnosti = new Station(3, Maidan_Nezalezhnosti, 7);
			Station st_Ploscha_Lva_Tolstogo = new Station(3, Ploscha_Lva_Tolstogo, 8);
			Station st_Olimpiiska = new Station(3, Olimpiiska, 9);
			Station st_Palats_Ukrayina = new Station(3, Palats_Ukrayina, 10);
			Station st_Lybidska = new Station(3, Lybidska, 11);
			Station st_Demiivska = new Station(3, Demiivska, 12);
			Station st_Holosiivska = new Station(3, Holosiivska, 13);
			Station st_Vasylkivska = new Station(3, Vasylkivska, 14);
			Station st_Vystavkovyi_Tsentr = new Station(3, Vystavkovyi_Tsentr, 15);
			Station st_Ipodrom = new Station(3, Ipodrom, 16);
			Station st_Teremky = new Station(3, Teremky, 17);
			#endregion
			#region Green_Branch_Connections_Selection
			Station_db[0] = mth_select_connections(st_Syrets, st_Dorohozhchi, null, null);
			Station_db[1] = mth_select_connections(st_Dorohozhchi, st_Lukianivska, st_Syrets, null);
			Station_db[2] = mth_select_connections(st_Lukianivska, st_Lvivska_Brama, st_Dorohozhchi, null);
			Station_db[3] = mth_select_connections(st_Lvivska_Brama, st_Zoloti_Vorota, st_Lukianivska, null);
			Station_db[4] = mth_select_connections(st_Zoloti_Vorota, st_Palats_sportu, st_Lvivska_Brama, st_Teatralna);
			Station_db[5] = mth_select_connections(st_Palats_sportu, st_Klovska, st_Zoloti_Vorota, st_Ploscha_Lva_Tolstogo);
			Station_db[6] = mth_select_connections(st_Klovska, st_Pecherska, st_Palats_sportu, null);
			Station_db[7] = mth_select_connections(st_Pecherska, st_Druzhby_Narodiv, st_Klovska, null);
			Station_db[8] = mth_select_connections(st_Druzhby_Narodiv, st_Vydubychi, st_Pecherska, null);
			Station_db[9] = mth_select_connections(st_Vydubychi, st_Telychka, st_Druzhby_Narodiv, null);
			Station_db[10] = mth_select_connections(st_Telychka, st_Slavutych, st_Vydubychi, null);
			Station_db[11] = mth_select_connections(st_Slavutych, st_Osokorky, st_Telychka, null);
			Station_db[12] = mth_select_connections(st_Osokorky, st_Pozniaky, st_Slavutych, null);
			Station_db[13] = mth_select_connections(st_Pozniaky, st_Kharkivska, st_Osokorky, null);
			Station_db[14] = mth_select_connections(st_Kharkivska, st_Vyrlytsia, st_Pozniaky, null);
			Station_db[15] = mth_select_connections(st_Vyrlytsia, st_Boryspilska, st_Kharkivska, null);
			Station_db[16] = mth_select_connections(st_Boryspilska, st_Chervony_Khutir, st_Vyrlytsia, null);
			Station_db[17] = mth_select_connections(st_Chervony_Khutir, null, st_Boryspilska, null);
			#endregion
			#region Red_Branch_Connections_Selection
			Station_db[18] = mth_select_connections(st_Akademmistechko, st_Zhytomyrska, null, null);
			Station_db[19] = mth_select_connections(st_Zhytomyrska, st_Sviatoshyn, st_Akademmistechko, null);
			Station_db[20] = mth_select_connections(st_Sviatoshyn, st_Nyvky, st_Zhytomyrska, null);
			Station_db[21] = mth_select_connections(st_Nyvky, st_Beresteiska, st_Sviatoshyn, null);
			Station_db[22] = mth_select_connections(st_Beresteiska, st_Shuliavska, st_Nyvky, null);
			Station_db[23] = mth_select_connections(st_Shuliavska, st_Politkhnichnyi_Instytut, st_Beresteiska, null);
			Station_db[24] = mth_select_connections(st_Politkhnichnyi_Instytut, st_Vokzalna, st_Shuliavska, null);
			Station_db[25] = mth_select_connections(st_Vokzalna, st_Universytet, st_Politkhnichnyi_Instytut, null);
			Station_db[26] = mth_select_connections(st_Universytet, st_Teatralna, st_Vokzalna, null);
			Station_db[27] = mth_select_connections(st_Teatralna, st_Khreshatyk, st_Universytet, st_Zoloti_Vorota);
			Station_db[28] = mth_select_connections(st_Khreshatyk, st_Arsenalna, st_Teatralna, st_Maidan_Nezalezhnosti);
			Station_db[29] = mth_select_connections(st_Arsenalna, st_Dnipro, st_Khreshatyk, null);
			Station_db[30] = mth_select_connections(st_Dnipro, st_Hidropark, st_Arsenalna, null);
			Station_db[31] = mth_select_connections(st_Hidropark, st_Livoberezhna, st_Dnipro, null);
			Station_db[32] = mth_select_connections(st_Livoberezhna, st_Darnitsia, st_Hidropark, null);
			Station_db[33] = mth_select_connections(st_Darnitsia, st_Chernihivska, st_Livoberezhna, null);
			Station_db[34] = mth_select_connections(st_Chernihivska, st_Lisova, st_Darnitsia, null);
			Station_db[35] = mth_select_connections(st_Lisova, null, st_Chernihivska, null);
			#endregion
			#region Blue_Branch_Connections_Selection
			Station_db[36] = mth_select_connections(st_Heroiv_Dnipra, st_Minska, null, null);
			Station_db[37] = mth_select_connections(st_Minska, st_Obolon, st_Heroiv_Dnipra, null);
			Station_db[38] = mth_select_connections(st_Obolon, st_Petrivka, st_Minska, null);
			Station_db[39] = mth_select_connections(st_Petrivka, st_Tarasa_Shevchenka, st_Obolon, null);
			Station_db[40] = mth_select_connections(st_Tarasa_Shevchenka, st_Kontraktova_Ploshcha, st_Petrivka, null);
			Station_db[41] = mth_select_connections(st_Kontraktova_Ploshcha, st_Poshtova_Ploshcha, st_Tarasa_Shevchenka, null);
			Station_db[42] = mth_select_connections(st_Poshtova_Ploshcha, st_Maidan_Nezalezhnosti, st_Kontraktova_Ploshcha, null);
			Station_db[43] = mth_select_connections(st_Maidan_Nezalezhnosti, st_Ploscha_Lva_Tolstogo, st_Poshtova_Ploshcha, st_Khreshatyk);
			Station_db[44] = mth_select_connections(st_Ploscha_Lva_Tolstogo, st_Olimpiiska, st_Maidan_Nezalezhnosti, st_Palats_sportu);
			Station_db[45] = mth_select_connections(st_Olimpiiska, st_Palats_Ukrayina, st_Ploscha_Lva_Tolstogo, null);
			Station_db[46] = mth_select_connections(st_Palats_Ukrayina, st_Lybidska, st_Olimpiiska, null);
			Station_db[47] = mth_select_connections(st_Lybidska, st_Demiivska, st_Palats_Ukrayina, null);
			Station_db[48] = mth_select_connections(st_Demiivska, st_Holosiivska, st_Lybidska, null);
			Station_db[49] = mth_select_connections(st_Holosiivska, st_Vasylkivska, st_Demiivska, null);
			Station_db[50] = mth_select_connections(st_Vasylkivska, st_Vystavkovyi_Tsentr, st_Holosiivska, null);
			Station_db[51] = mth_select_connections(st_Vystavkovyi_Tsentr, st_Ipodrom, st_Vasylkivska, null);
			Station_db[52] = mth_select_connections(st_Ipodrom, st_Teremky, st_Vystavkovyi_Tsentr, null);
			Station_db[53] = mth_select_connections(st_Teremky, null, st_Ipodrom, null);
			#endregion
		}

		private Station mth_check_branch(Station start_st, Station finish_st)
		{
			if (start_st.branch != finish_st.branch)
			{
				for (int i = 0; i < 54; i++)
					if (Station_db[i].transfer != null)
						if (Station_db[i].branch == start_st.branch && Station_db[i].transfer.branch == finish_st.branch)
							return (Station_db[i]);
			}
			return (null);
		}

		private async void	mth_transfer_on_branch(Station current_st, Station finish_st)
		{
			if (current_st.id < finish_st.id)
				while (current_st.id < finish_st.id)
				{
					current_st.obj.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 0, 255));
					current_st = current_st.next;
					await Task.Delay(step_delay);
					current_st.prev.obj.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 255, 0));
				}
			else
				while (current_st.id > finish_st.id)
				{
					current_st.obj.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 0, 255));
					current_st = current_st.prev;
					await Task.Delay(step_delay);
					current_st.next.obj.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 255, 0));
				}
		}

		private async void GO_Click(object sender, RoutedEventArgs e)
		{
			Station current_st = new Station();
			Station finish_st = new Station();
			Station transfer_st = null;

			if (st_sl == 1 && fn_sl == 1)
			{
				for (int i = 0; i < 54; i++)
					if (Station_db[i].selected == 1)
						current_st = Station_db[i];
					else if (Station_db[i].selected == 2)
						finish_st = Station_db[i];
				transfer_st = mth_check_branch(current_st, finish_st);
				if (transfer_st == null)
				{
					mth_transfer_on_branch(current_st, finish_st);
					await Task.Delay(step_delay * Math.Abs(current_st.id - finish_st.id));
					Clear.IsEnabled = true;
				}
				else
				{
					mth_transfer_on_branch(current_st, transfer_st);
					await Task.Delay(step_delay * Math.Abs(current_st.id - transfer_st.id));
					transfer_st.obj.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 0, 255));
					await Task.Delay(step_delay);
					transfer_st.obj.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 255, 0));
					mth_transfer_on_branch(transfer_st.transfer, finish_st);
					await Task.Delay(step_delay * Math.Abs(transfer_st.transfer.id - finish_st.id));
					Clear.IsEnabled = true;
				}
			}
		}

		private void mth_set_unselected(int	i)
		{
			if (Station_db[i].selected == 1)
				st_sl = 0;
			else if (Station_db[i].selected == 2)
				fn_sl = 0;
			Station_db[i].selected = 0;
			Station_db[i].obj.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
		}

		private void mth_set_start_selected(int i)
		{
			Station_db[i].selected = 1;
			st_sl = 1;
			Station_db[i].obj.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 255, 0));
		}

		private void mth_set_finish_selected(int i)
		{
			Station_db[i].selected = 2;
			fn_sl = 1;
			Station_db[i].obj.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 0, 255));
		}

		private void Handle_Click(object sender, MouseButtonEventArgs e)
		{
			Ellipse st = sender as Ellipse;
			int		i = -1;

			if (st_sl == 0 && fn_sl == 0)
			{
				st_sl = 1;
				while (++i < 54)
					if (st.Name.ToString() == Station_db[i].obj.Name.ToString())
					{
						Station_db[i].selected = 1;
						Station_db[i].obj.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 255, 0));
						break ;
					}
			}
			else
				while (++i < 54)
					if (st.Name.ToString() == Station_db[i].obj.Name.ToString())
					{
						if (Station_db[i].selected > 0)
							mth_set_unselected(i);
						else
							if (st_sl == 0)
							mth_set_start_selected(i);
						else if (fn_sl == 0)
							mth_set_finish_selected(i);
						break ;
					}
		}

		private void Clear_Click(object sender, RoutedEventArgs e)
		{
			int i = -1;

			st_sl = 0;
			fn_sl = 0;
			while (++i < 54)
			{
				Station_db[i].selected = 0;
				Station_db[i].obj.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
			}
			Clear.IsEnabled = false;
		}

		private void Exit_btn_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(1);
		}
	}
}
