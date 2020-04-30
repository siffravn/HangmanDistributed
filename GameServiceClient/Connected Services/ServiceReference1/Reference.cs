﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameServiceClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Hangman", Namespace="http://schemas.datacontract.org/2004/07/GameService.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[]))]
    public partial class Hangman : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HiddenWordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsGameLostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsGameWonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsGuessCorrectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LivesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object[] UsedLettersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VisibleWordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HiddenWord {
            get {
                return this.HiddenWordField;
            }
            set {
                if ((object.ReferenceEquals(this.HiddenWordField, value) != true)) {
                    this.HiddenWordField = value;
                    this.RaisePropertyChanged("HiddenWord");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsGameLost {
            get {
                return this.IsGameLostField;
            }
            set {
                if ((this.IsGameLostField.Equals(value) != true)) {
                    this.IsGameLostField = value;
                    this.RaisePropertyChanged("IsGameLost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsGameWon {
            get {
                return this.IsGameWonField;
            }
            set {
                if ((this.IsGameWonField.Equals(value) != true)) {
                    this.IsGameWonField = value;
                    this.RaisePropertyChanged("IsGameWon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsGuessCorrect {
            get {
                return this.IsGuessCorrectField;
            }
            set {
                if ((this.IsGuessCorrectField.Equals(value) != true)) {
                    this.IsGuessCorrectField = value;
                    this.RaisePropertyChanged("IsGuessCorrect");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Lives {
            get {
                return this.LivesField;
            }
            set {
                if ((this.LivesField.Equals(value) != true)) {
                    this.LivesField = value;
                    this.RaisePropertyChanged("Lives");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object[] UsedLetters {
            get {
                return this.UsedLettersField;
            }
            set {
                if ((object.ReferenceEquals(this.UsedLettersField, value) != true)) {
                    this.UsedLettersField = value;
                    this.RaisePropertyChanged("UsedLetters");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisibleWord {
            get {
                return this.VisibleWordField;
            }
            set {
                if ((object.ReferenceEquals(this.VisibleWordField, value) != true)) {
                    this.VisibleWordField = value;
                    this.RaisePropertyChanged("VisibleWord");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGameController")]
    public interface IGameController {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameController/CreateGame", ReplyAction="http://tempuri.org/IGameController/CreateGameResponse")]
        GameServiceClient.ServiceReference1.Hangman CreateGame(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameController/CreateGame", ReplyAction="http://tempuri.org/IGameController/CreateGameResponse")]
        System.Threading.Tasks.Task<GameServiceClient.ServiceReference1.Hangman> CreateGameAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameController/TerminateGame", ReplyAction="http://tempuri.org/IGameController/TerminateGameResponse")]
        void TerminateGame(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameController/TerminateGame", ReplyAction="http://tempuri.org/IGameController/TerminateGameResponse")]
        System.Threading.Tasks.Task TerminateGameAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameController/Guess", ReplyAction="http://tempuri.org/IGameController/GuessResponse")]
        GameServiceClient.ServiceReference1.Hangman Guess(int id, [System.ServiceModel.MessageParameterAttribute(Name="guess")] string guess1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameController/Guess", ReplyAction="http://tempuri.org/IGameController/GuessResponse")]
        System.Threading.Tasks.Task<GameServiceClient.ServiceReference1.Hangman> GuessAsync(int id, string guess);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameController/NewGame", ReplyAction="http://tempuri.org/IGameController/NewGameResponse")]
        GameServiceClient.ServiceReference1.Hangman NewGame(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameController/NewGame", ReplyAction="http://tempuri.org/IGameController/NewGameResponse")]
        System.Threading.Tasks.Task<GameServiceClient.ServiceReference1.Hangman> NewGameAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameController/ComputeScore", ReplyAction="http://tempuri.org/IGameController/ComputeScoreResponse")]
        int ComputeScore(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameController/ComputeScore", ReplyAction="http://tempuri.org/IGameController/ComputeScoreResponse")]
        System.Threading.Tasks.Task<int> ComputeScoreAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameControllerChannel : GameServiceClient.ServiceReference1.IGameController, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameControllerClient : System.ServiceModel.ClientBase<GameServiceClient.ServiceReference1.IGameController>, GameServiceClient.ServiceReference1.IGameController {
        
        public GameControllerClient() {
        }
        
        public GameControllerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GameControllerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameControllerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameControllerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GameServiceClient.ServiceReference1.Hangman CreateGame(int id) {
            return base.Channel.CreateGame(id);
        }
        
        public System.Threading.Tasks.Task<GameServiceClient.ServiceReference1.Hangman> CreateGameAsync(int id) {
            return base.Channel.CreateGameAsync(id);
        }
        
        public void TerminateGame(int id) {
            base.Channel.TerminateGame(id);
        }
        
        public System.Threading.Tasks.Task TerminateGameAsync(int id) {
            return base.Channel.TerminateGameAsync(id);
        }
        
        public GameServiceClient.ServiceReference1.Hangman Guess(int id, string guess1) {
            return base.Channel.Guess(id, guess1);
        }
        
        public System.Threading.Tasks.Task<GameServiceClient.ServiceReference1.Hangman> GuessAsync(int id, string guess) {
            return base.Channel.GuessAsync(id, guess);
        }
        
        public GameServiceClient.ServiceReference1.Hangman NewGame(int id) {
            return base.Channel.NewGame(id);
        }
        
        public System.Threading.Tasks.Task<GameServiceClient.ServiceReference1.Hangman> NewGameAsync(int id) {
            return base.Channel.NewGameAsync(id);
        }
        
        public int ComputeScore(int id) {
            return base.Channel.ComputeScore(id);
        }
        
        public System.Threading.Tasks.Task<int> ComputeScoreAsync(int id) {
            return base.Channel.ComputeScoreAsync(id);
        }
    }
}
