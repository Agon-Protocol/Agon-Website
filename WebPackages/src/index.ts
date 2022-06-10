import {
    SigningCosmWasmClient
} from "@cosmjs/cosmwasm-stargate";
import { Window as KeplrWindow, Key } from "@keplr-wallet/types";

declare global {
    interface Window extends KeplrWindow { }
}

window.addEventListener("keplr_keystorechange", (e) => {
    //forward this event to the profile control
    var web3Profile = document.getElementById("web3Profile");
    web3Profile.dispatchEvent(new Event("keplrkeystorechange", { bubbles: true }));
});

export async function connectKeplr(chainId: string): Promise<Key | null> {
    if (!window.keplr) {
        return null;
    }
    
    // Enabling before using the Keplr is recommended.
    // This method will ask the user whether to allow access if they haven't visited this website.
    // Also, it will request that the user unlock the wallet if the wallet is locked.
    await window.keplr.enable(chainId);

    var key = await window.keplr.getKey(chainId);

    return key;
}

export async function suggestChain(chainId: string, chainName: string, rpc: string,
    rest: string, coinType: number, accountPrefix: string,
    coinDenom: string, coinMinDenom: string, coinDecimals: number): Promise<Key | null> {
    if (!window.keplr.experimentalSuggestChain) {
        return null;
    }

    await window.keplr.experimentalSuggestChain({
        chainId: chainId,
        chainName: chainName,
        rpc: rpc,
        rest: rest,
        bip44: {
            coinType: coinType,
        },
        bech32Config: {
            bech32PrefixAccAddr: accountPrefix,
            bech32PrefixAccPub: accountPrefix + "pub",
            bech32PrefixValAddr: accountPrefix + "valoper",
            bech32PrefixValPub: accountPrefix + "valoperpub",
            bech32PrefixConsAddr: accountPrefix + "valcons",
            bech32PrefixConsPub: accountPrefix + "valconspub",
        },
        currencies: [
            {
                coinDenom: coinDenom,
                coinMinimalDenom: coinMinDenom,
                coinDecimals: coinDecimals,
                coinGeckoId: accountPrefix,
            },
        ],
        feeCurrencies: [
            {
                coinDenom: coinDenom,
                coinMinimalDenom: coinMinDenom,
                coinDecimals: coinDecimals,
                coinGeckoId: accountPrefix,
            },
        ],
        stakeCurrency: {
            coinDenom: coinDenom,
            coinMinimalDenom: coinMinDenom,
            coinDecimals: coinDecimals,
            coinGeckoId: accountPrefix,
        },
        coinType: coinType,
        gasPriceStep: {
            low: 0.01,
            average: 0.025,
            high: 0.03,
        },
    });

    return await connectKeplr(chainId);
}