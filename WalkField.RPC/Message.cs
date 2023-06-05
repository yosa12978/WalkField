using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace WalkField.RPC
{
    public class Message<T>
    {
        public Cmd cmd { get; set; } = default(Cmd);
        public T args { get; set; } = default!;
        public string nonce { get; set; } = default!;

        public string Serialize() => 
            JsonConvert.SerializeObject(this);
        public static Message<T>? Deserialize(string json) =>
            JsonConvert.DeserializeObject<Message<T>>(json);
    }
}
