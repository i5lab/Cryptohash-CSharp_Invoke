const edge = require("edge-js");
const DLLPATH =
  "BlockChain\\CryptoHash_edge-js\\bin\\Debug\\net481\\CryptoHash.dll";

const cryptoHashHex = edge.func({
  assemblyFile: DLLPATH,
  typeName: "CryptoHash.CryptoHashClass",
  methodName: "ComputeStringToSha256Hash",
});

const cryptoHash = (...inputs) => {
  cryptoHashHex(inputs.sort().join(" "), (err, res) => {
    stringHex = res.Result;
  });
  return stringHex;
};

//console.log(cryptoHash("hjhjgjjdf"));

module.exports = cryptoHash;
