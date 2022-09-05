const { promisify } = require("util");
const exec = promisify(require("child_process").exec);

// const cryptoHash = async (...inputs) => {
//   const inp = inputs.sort().join(" ");
//   return await new Promise((resolve2) => {
//     exec(`BlockChain\\Crypto-STDout.exe ${inp}`, (error, stdout, stderr) => {
//       //console.log(stdout);
//       resolve2(stdout);

//       //console.log(stderr);
//     });
//   });
// };

const cryptoHash = async (...inputs) => {
  const inp = inputs.sort().join(" ");
  var a = "Empty";
  return await (
    await exec(`BlockChain\\Crypto-STDout.exe ${inp}`)
  ).stdout.trim();
};

// (async () => {
//   console.log(await cryptoHash("fdffgdf"));
// })();

for (let i = 1; i <= 1000; i++)
  (async () => {
    const t = await cryptoHash(i.toString());

    console.log(t);
  })();

module.exports = cryptoHash;
