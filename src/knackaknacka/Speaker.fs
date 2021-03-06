module knackaknacka.Speaker

open System.Speech.Synthesis

let synth = new SpeechSynthesizer()

let ssmlStart = 
    "<speak version=\"1.0\" xmlns=\"http://www.w3.org/2001/10/synthesis\" \
    xml:lang=\"en-US\"> <phoneme alphabet=\"ipa\" ph=\""

let ssmlEnd = 
    "\">dummy</phoneme></speak>"

let ssmlWrap x =
    ssmlStart + x + ssmlEnd

let sayIpa x =
    synth.SpeakSsml(ssmlWrap x)
