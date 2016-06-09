using System;
using DotSlack.Models;

namespace DotSlack.Dispatchers
{ 
    public class SlashCommandDispatcher : Dispatcher
    {
        public void Dispatch(SlashCommand command)
        {
            var parameters = command.Text.Split(' ');

            if(command.Command.Equals(nameof(GitRepos), StringComparison.OrdinalIgnoreCase))
            {
                
            }
        }

        public void GitRepos(string[] parameters)
        {
            if (parameters.Length > 1)
            {
                PostError("Too many parameters. Please enter only the username.");
            }

            var gitHubUserName = parameters[0];
        }
    }
}
