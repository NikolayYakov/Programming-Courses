// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
     
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
	public class StageTests
    {
		private Song song;
		private Performer performer;
		private Stage stage;
		private string songName = "Az sum pich";
		private TimeSpan duration = new TimeSpan(0,3,20);
		private string firstName = "Pesho";
		private string secondName = "Kavalski";
		private int age = 30;
        [SetUp]
	    public void SetUp()
	    {
			song = new Song(songName,duration);
			performer = new Performer(firstName,secondName,age);
			stage = new Stage();
		}
		[Test]
		public void WhenStageCreatedOneListShouldBeCreated()
        {
			 
			List<Performer> performers = new List<Performer>();
			Assert.AreEqual(performers, stage.Performers);

		}
		[Test]
		public void WhenAddingAPerformerAndHeIsNullThrowException()
        {
			performer = null;
			Assert.Throws<ArgumentNullException>(() => stage.AddPerformer(performer));
        }
		[Test]
		public void WhenYouAddPerformetUndet18Throw()
        {
			performer = new Performer(firstName, songName, 15);
			Assert.Throws<ArgumentException>(() => stage.AddPerformer(performer));
        }
		[Test]
		public void WhenCorrectlyPerformerShouldBeAdded()
        {
			stage.AddPerformer(performer);
			Assert.AreEqual(stage.Performers.Count, 1);
            foreach (var item in stage.Performers)
            {
				Assert.AreEqual(item, performer);
			}
			
        }
		[Test]
		public void WhneYouTryToAddSongsLowerThanAMinetThrow()
        {
			TimeSpan duration = new TimeSpan(0, 0, 10);
			song = new Song(songName,duration);
			Assert.Throws<ArgumentException>(() => stage.AddSong(song));
        }
		[Test]
		public void WhenSongIsNullThrow()
        {
			song = null;
			Assert.Throws<ArgumentNullException>(() => stage.AddSong(song));
		}
		[Test]
		public void WhenYouTryToAddToANullPerformarThrow()
        {
			string nameTest = null;
			stage.AddSong(song);
			Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer(song.Name,nameTest));

		}
		[Test]
		public void WhenYouTryToAddNullSong()
        {
			string song = null;
			stage.AddPerformer(performer);
			Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer(song, performer.FullName));

		}
		[Test]
		public void WhenCorrectSongShouldBeAdd()
        {
			stage.AddPerformer(performer);
			stage.AddSong(song);
		    string msg = stage.AddSongToPerformer(song.Name,performer.FullName);
			Assert.AreEqual(msg, $"{song} will be performed by {performer}");
			Assert.AreEqual(performer.SongList.Count, 1);
        }
		[Test]
		public void WhenPlayReturnHowMannysongs()
        {
			stage.AddPerformer(performer);
			stage.AddPerformer(new Performer("Gosho", "Pich", 23));
			stage.AddSong(song);
			stage.AddSong(new Song("Tupo", new TimeSpan(0, 3, 0)));
			stage.AddSongToPerformer(song.Name, performer.FullName);
			stage.AddSongToPerformer("Tupo", "Gosho Pich");
			string msg =stage.Play();
			Assert.AreEqual(msg, $"{2} performers played {2} songs");
        }
		[Test]
		public void WhenThereIsNoSuchPerformerThrow()
        {
			stage.AddSong(song);
			Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer(song.Name, "Pesho Divaka"));
        }
		[Test]
		public void WhenThereIsNoSuchSongThrow()
        {
			stage.AddPerformer(performer);
			Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("Nqma Takava", performer.FullName));

		}
	}
}