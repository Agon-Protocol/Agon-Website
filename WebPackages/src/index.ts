import {
    SigningCosmWasmClient
} from "@cosmjs/cosmwasm-stargate";
import { Window as KeplrWindow } from "@keplr-wallet/types";

declare global {
    interface Window extends KeplrWindow { }
}

export async function connectKeplr(chainId: string): Promise<string | null> {
    if (!window.getOfflineSigner || !window.keplr) {
        return null;
    } else {
        // Enabling before using the Keplr is recommended.
        // This method will ask the user whether to allow access if they haven't visited this website.
        // Also, it will request that the user unlock the wallet if the wallet is locked.
        await window.keplr.enable(chainId);

        const offlineSigner = await window.keplr.getOfflineSigner(chainId);
        const accounts = await offlineSigner.getAccounts();

        return accounts[0].address;
    }
}

export async function connectKeplrToDesmos(chainId: string, rpc: string, rest: string): Promise<string | null> {
    if (!window.keplr.experimentalSuggestChain) {
        return null;
    }

    // Keplr defaults to a derivation path using coin_type = 118, but Desmos uses coin_type = 852.
    // A desmos profile would have to be set up under Keplr's derivation path, or forbole x should expose an api.
    // https://keplr.crunch.help/keplr-wallet-features/how-to-set-a-custom-derivation-path
    await window.keplr.experimentalSuggestChain({
        chainId: chainId,
        // The name of the chain to be displayed to the user.
        chainName: "Desmos",
        // RPC endpoint of the chain.
        rpc: rpc,
        // REST endpoint of the chain.
        rest: rest,
        // Staking coin information
        stakeCurrency: {
            // Coin denomination to be displayed to the user.
            coinDenom: "DSM",
            // Actual denom (i.e. uatom, uscrt) used by the blockchain.
            coinMinimalDenom: "udsm",
            // # of decimal points to convert minimal denomination to user-facing denomination.
            coinDecimals: 6,
            // (Optional) Keplr can show the fiat value of the coin if a coingecko id is provided.
            // You can get id from https://api.coingecko.com/api/v3/coins/list if it is listed.
            coinGeckoId: "desmos"
        },
        // (Optional) If you have a wallet webpage used to stake the coin then provide the url to the website in `walletUrlForStaking`.
        // The 'stake' button in Keplr extension will link to the webpage.
        walletUrlForStaking: "https://x.forbole.com/staking",
        // The BIP44 path.
        bip44: {
            // You can only set the coin type of BIP44.
            // 'Purpose' is fixed to 44.
            coinType: 852,
        },
        // Bech32 configuration to show the address to user.
        // This field is the interface of
        // {
        //   bech32PrefixAccAddr: string;
        //   bech32PrefixAccPub: string;
        //   bech32PrefixValAddr: string;
        //   bech32PrefixValPub: string;
        //   bech32PrefixConsAddr: string;
        //   bech32PrefixConsPub: string;
        // }
        bech32Config: {
            bech32PrefixAccAddr: "desmos",
            bech32PrefixAccPub: "desmospub",
            bech32PrefixValAddr: "desmosvaloper",
            bech32PrefixValPub: "desmosvaloperpub",
            bech32PrefixConsAddr: "desmosvalcons",
            bech32PrefixConsPub: "desmosvalconspub"
        },
        // List of all coin/tokens used in this chain.
        currencies: [{
            // Coin denomination to be displayed to the user.
            coinDenom: "DSM",
            // Actual denom (i.e. uatom, uscrt) used by the blockchain.
            coinMinimalDenom: "udsm",
            // # of decimal points to convert minimal denomination to user-facing denomination.
            coinDecimals: 6,
            // (Optional) Keplr can show the fiat value of the coin if a coingecko id is provided.
            // You can get id from https://api.coingecko.com/api/v3/coins/list if it is listed.
            coinGeckoId: "desmos"
        }],
        // List of coin/tokens used as a fee token in this chain.
        feeCurrencies: [{
            // Coin denomination to be displayed to the user.
            coinDenom: "DSM",
            // Actual denom (i.e. uatom, uscrt) used by the blockchain.
            coinMinimalDenom: "udsm",
            // # of decimal points to convert minimal denomination to user-facing denomination.
            coinDecimals: 6,
            // (Optional) Keplr can show the fiat value of the coin if a coingecko id is provided.
            // You can get id from https://api.coingecko.com/api/v3/coins/list if it is listed.
            coinGeckoId: "desmos"
        }]
    });

    return await connectKeplr(chainId);
}